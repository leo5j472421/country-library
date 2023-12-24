using CountryLibraryAPI.Controllers;
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
}