using CountryLibraryAPI.Model;
using CountryLibraryAPI.Repository;
using CountryLibraryAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private readonly ILogger<CountryController> _logger;
    private readonly CountryService _countryService;

    public CountryController(ILogger<CountryController> logger, CountryService countryService)
    {
        _logger = logger;
        _countryService = countryService;
    }

    [HttpGet]
    [Route("GetCountries")]
    public async Task<IEnumerable<CountryDto>> Get()
    {
        return await _countryService.GetCountriesAsync();
    }

    [Route("AddCountry")]
    [HttpPost]
    public async Task Add(CountryDto country)
    {
        await _countryService.Add(country);
    }

    [Route("UpdateCountry")]
    [HttpPost]
    public async Task Update(CountryDto country)
    {
        await _countryService.Update(country);
    }

    [Route("DeleteCountry/{id}")]
    [HttpPost]
    public async Task Delete(int id)
    {
        await _countryService.Delete(id);
    }
}