using Dapper;
using System.Data;

namespace Data.Respository
{
    public class NameRepository : INameRepository
    {
        private readonly DapperContext _dapperContext;
        public NameRepository(DapperContext dapperContext) => _dapperContext = dapperContext;

        async Task INameRepository.CreateNewName(RandomNameDto randomName)
        {
            var query = "INSERT INTO RandomName (Name, ComputerApi) VALUES (@Name, @ComputerApi)";

            var parameters = new DynamicParameters();
            parameters.Add("Name", randomName.Name, DbType.String);
            parameters.Add("ComputerApi", randomName.ComputerApi, DbType.String);

            using (var connection = _dapperContext.CreateConnection())
            {
                var x = await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
