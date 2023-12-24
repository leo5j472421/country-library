using Microsoft.AspNetCore.Mvc;

namespace CountryLibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private readonly ILogger<CountryController> _logger;

    public CountryController(ILogger<CountryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCountries")]
    public IEnumerable<CountryDto> Get()
    {
        return new List<CountryDto>()
        {
            new CountryDto()
            {
                Id = 1,
                Name = "India",
                Language = "Hindi",
                Currency = "INR",
                Population = 1380004385
            }
        };
    }
}

public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Language { get; set; }
    public string Currency { get; set; }
    public int Population { get; set; }
}