using MediatR;

namespace Application.Name
{
    public class GenerateAndSaveNameCommand : IRequest<List<string>>
    {
        public int Count { get; }

        public GenerateAndSaveNameCommand(int count)
        {
            Count = count;
        }
    }
}
