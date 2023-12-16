using Data.Respository;
using Domain.ReturnedNames;
using MediatR;
using Application.IP;

namespace Application.Name
{
    public class GenerateAndSaveNameCommandHandler : IRequestHandler<GenerateAndSaveNameCommand, List<string>>
    {
        private readonly IReturnedNameRepository _returnedNameRepository;
        private readonly INameRepository _nameRepository;

        public GenerateAndSaveNameCommandHandler(
            IReturnedNameRepository returnedNameRepository,
            INameRepository nameRepository)
        {
            _returnedNameRepository = returnedNameRepository ?? throw new ArgumentNullException(nameof(returnedNameRepository));            
            _nameRepository = nameRepository ?? throw new ArgumentNullException(nameof(nameRepository));
        }

        public async Task<List<string>> Handle(GenerateAndSaveNameCommand command, CancellationToken cancellationToken)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            List<string> result = new List<string>();
            for (int i = 0; i < command.Count; i++)
            {
                string currentRandomName = _returnedNameRepository.GenerateName();
                result.Add(currentRandomName);
                await _nameRepository.CreateNewName(new RandomNameDto
                {
                    Name = currentRandomName,
                    ComputerApi = CurrentIPAddress.GetLocalIPAddress()
                });
            }

            return result;
        }
    }
}
