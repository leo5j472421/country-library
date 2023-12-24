using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CountryLibraryAPI.Repository;

public abstract class BaseRepository
{
    private readonly IDbConnection _connection;
    protected BaseRepository(string dbName, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(dbName);
        _connection = new SqlConnection(connectionString);;
    }

    protected async Task<IEnumerable<T>> QueryAsync<T>(string spName, object parameter = null)
    {
        var results = await _connection.QueryAsync<T>
            (spName, parameter, commandType: CommandType.StoredProcedure);
        return results;
    }
}