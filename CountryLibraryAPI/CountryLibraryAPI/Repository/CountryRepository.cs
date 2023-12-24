using System.Data;
using CountryLibraryAPI.Controllers;

namespace CountryLibraryAPI.Repository;

public class CountryRepository : BaseRepository
{
    public CountryRepository(IConfiguration configuration) : base("CountryLibraryDB", configuration)
    {
    }

    public async Task<IEnumerable<CountryDto>> GetCountriesAsync()
    {
        var countries = await QueryAsync<CountryDto>("[dbo].[GetCountries]");
        return countries;
    }
}