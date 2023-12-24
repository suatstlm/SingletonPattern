using SingletonPattern.Model;

namespace SingletonPattern;

public class CountryProvider
{
    private new List<Country> Countries { get; set; }

    private static CountryProvider instance = null;
    public static CountryProvider Instance => instance ?? (instance = new CountryProvider());

    private CountryProvider()
    {
        // Retrieving data from db
        Task.Delay(2000).GetAwaiter().GetResult();

        Countries = new List<Country>()
        {
            new Country(){ Name = "Türkiye" },
            new Country(){ Name = "France" },
            new Country(){ Name = "ABD" },
        };
    }

    public async Task<List<Country>> GetCountries() => Countries;

    public int CountryCount => Countries.Count;
}
