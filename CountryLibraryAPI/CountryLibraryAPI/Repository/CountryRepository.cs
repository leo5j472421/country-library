using System.Data;
using CountryLibraryAPI.Controllers;
using CountryLibraryAPI.Model;

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

    public async Task DeleteCountry(int id)
    {
        await QueryAsync<CountryDto>("[dbo].[DeleteCountry]", new {Id = id});
    }

    public async Task AddCountry(CountryDto country)
    {
        await QueryAsync<CountryDto>("[dbo].[AddCountry]", new
        {
            Name = country.Name,
            Language = country.Language,
            Currency = country.Currency,
            Capital = country.Capital,
            Population = country.Population
        });
    }

    public async Task UpdateCountry(CountryDto country)
    {
        await QueryAsync<int>("[dbo].[UpdateCountry]", new
        {
            Id = country.Id,
            Name = country.Name,
            Language = country.Language,
            Currency = country.Currency,
            Capital = country.Capital,
            Population = country.Population
        });
    }
}