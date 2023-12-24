using CountryLibraryAPI.Controllers;
using CountryLibraryAPI.Model;
using CountryLibraryAPI.Repository;

namespace CountryLibraryAPI.Service;

public class CountryService
{
    private CountryRepository _countryRepository;

    public CountryService(CountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<IEnumerable<CountryDto>> GetCountriesAsync()
    {
        return await _countryRepository.GetCountriesAsync();
    }

    public async Task Delete(int id)
    {
        await _countryRepository.DeleteCountry(id);
    }

    public async Task Add(CountryDto country)
    {
        await _countryRepository.AddCountry(country);
    }

    public async Task Update(CountryDto country)
    {
        await _countryRepository.UpdateCountry(country);
    }
}