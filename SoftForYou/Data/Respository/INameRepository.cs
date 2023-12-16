namespace Data.Respository
{
    public interface INameRepository
    {
        public Task CreateNewName(RandomNameDto randomName);
    }
}
