namespace HomeTask_16;

public class Program {
    public static void Main(string[] args)
    {
        #region Continent
        var eurasia = new Сontinent { Name = "Eurasia",};
        var northAmerica = new Сontinent { Name = "North America" };
        var australiaСontinent = new Сontinent { Name = "Australia Сontinent" };

        var continents = new List<Сontinent> { eurasia, northAmerica, australiaСontinent };
        #endregion

        #region Country
        var ukraine = new Country
        {
            Name = "Ukraine",
            Continent = eurasia
        };

        var france = new Country
        {
            Name = "France",
            Continent = eurasia

        };

        var australia = new Country
        {
            Name = "Australia",
            Continent = australiaСontinent
        };

        var usa = new Country
        {
            Name = "USA",
            Continent = northAmerica
        };
        #endregion 

        #region Сontinent.Countries
        eurasia.Countries.AddRange(new List<Country> { ukraine, france });
        northAmerica.Countries.AddRange(new List<Country> { usa });
        australiaСontinent.Countries.AddRange(new List<Country> { australia });
        #endregion

        #region Country.Cities
        ukraine.Cities.AddRange(new List<City>
            {
             new City { Name = "Kiev", Country = ukraine, Population = 3000000, FoundationDate = new DateTime(482, 1, 1), IsCapital = true },
             new City { Name = "Odesa", Country = ukraine, Population = 1500000, FoundationDate = new DateTime(1794, 1, 1), IsCapital = false }
            });

        france.Cities.AddRange(new List<City>
            {
             new City{Name = "Paris", Country = france, Population = 2148000, FoundationDate = new DateTime(52, 1, 1), IsCapital = true },
             new City {Name = "Marseille", Country = france, Population = 861635, FoundationDate = new DateTime(1, 1, 1), IsCapital = false }
            });

        australia.Cities.AddRange(new List<City>
            {
            new City {Name = "Canberra", Country = australia, Population = 447000, FoundationDate = new DateTime(1913, 3, 12), IsCapital = true },
            new City {Name = "Ararat", Country = australia, Population = 8344, FoundationDate = new DateTime(1857, 3, 21), IsCapital = false }
            });

        usa.Cities.AddRange(new List<City>
            {
            new City {Name = "New York", Population = 8399000, Country = usa, FoundationDate = new DateTime(1624, 1, 1), IsCapital = false},
            new City {Name = "Washington", Population = 713000, Country = usa, FoundationDate = new DateTime(1791, 7, 16), IsCapital = true}
            });
        #endregion

        #region Запити Linq
        // Вивести кількість країн по континентах
        var countriesPerContinent = continents.Select(c => new { Continent = c.Name, CountryCount = c.Countries.Count });

        foreach (var item in countriesPerContinent)
        {
            Console.WriteLine($"Continent: {item.Continent}, Country Count: {item.CountryCount}");
        }

        Console.WriteLine();

        // Вивести топ-3 міст за населенням без урахування тих, що були засновані після 1200 року
        var top3CitiesByPopulation = continents
            .SelectMany(c => c.Countries.SelectMany(ct => ct.Cities))
            .Where(city => city.FoundationDate.Year < 1200)
            .OrderByDescending(city => city.Population)
            .Take(3)
            .Select(city => city.Name);

        Console.WriteLine("Top 3 Cities by Population:");
        foreach (var city in top3CitiesByPopulation)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine();

        // Вивести країну з найбільшим населенням і її столицю
        var countryWithLargestPopulation = continents
            .SelectMany(c => c.Countries)
            .OrderByDescending(country => country.Cities.Sum(city => city.Population))
            .FirstOrDefault();

        if (countryWithLargestPopulation != null)
        {
            var capitalOfLargestCountry = countryWithLargestPopulation.Cities.FirstOrDefault(city => city.IsCapital);
            if (capitalOfLargestCountry != null)
            {
                Console.WriteLine($"Country with Largest Population: {countryWithLargestPopulation.Name}");
                Console.WriteLine($"Capital: {capitalOfLargestCountry.Name}");
            }
        }

        Console.WriteLine();

        // Вивести континенти з найбільшою кількістю міст, в яких населення перевищує 1,000,000
        var continentsWithMostCitiesOver1MillionPopulation = continents
            .Select(c => new
            {
                Continent = c.Name,
                CityCount = c.Countries.SelectMany(ct => ct.Cities).Count(city => city.Population > 1000000)
            })
            .OrderByDescending(c => c.CityCount);

        Console.WriteLine("Continents with Most Cities over 1 Million Population:");
        foreach (var item in continentsWithMostCitiesOver1MillionPopulation)
        {
            Console.WriteLine($"Continent: {item.Continent}, City Count: {item.CityCount}");
        }

        #endregion

    }
}
    
