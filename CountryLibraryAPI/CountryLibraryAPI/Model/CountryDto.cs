namespace CountryLibraryAPI.Model;

public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Language { get; set; }
    public string Currency { get; set; }
    public string Capital { get; set; }
    public int Population { get; set; }
}