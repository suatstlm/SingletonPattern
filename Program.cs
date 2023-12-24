using SingletonPattern;

Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries = await CountryProvider.Instance.GetCountries();


// Another service

Console.WriteLine(CountryProvider.Instance.CountryCount);

Console.WriteLine(DateTime.Now.ToLongTimeString());