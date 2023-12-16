namespace Domain.ReturnedNames
{
    public interface IReturnedNameRepository
    {
        ValueTask InsertAsync(string name);
        string GenerateName();
    }
}
