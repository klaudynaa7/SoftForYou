using Application.Name;
using Data.Respository;
using Domain.ReturnedNames;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SoftForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;
        private readonly IMediator _mediator;
        private readonly IReturnedNameRepository _returnedNameRepository;
        private readonly INameRepository _nameRepository;

        public NameController(
            ILogger<NameController> logger, 
            IMediator mediator,
            IReturnedNameRepository returnedNameRepository,
            INameRepository nameRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _returnedNameRepository = returnedNameRepository ?? throw new ArgumentNullException();
            _nameRepository = nameRepository ?? throw new ArgumentNullException();
        }

        [HttpPost("GenerateAndSaveName")]
        public async Task<ActionResult<List<string>?>> GenerateAndSaveName(int count, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _mediator.Send(new GenerateAndSaveNameCommand(count), cancellationToken);
                return result != null ? Ok(result) : BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }            
        }
    }
}