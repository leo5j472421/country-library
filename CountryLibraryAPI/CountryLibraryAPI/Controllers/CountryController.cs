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

    [HttpGet(Name = "GetCountries")]
    public async Task<IEnumerable<CountryDto>> Get()
    {
        return await _countryService.GetCountriesAsync();
    }
}

public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Language { get; set; }
    public string Currency { get; set; }
    public string Capital { get; set; }
    public int Population { get; set; }
}