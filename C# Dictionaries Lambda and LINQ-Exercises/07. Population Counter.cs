using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> populationOfCountries = new Dictionary<string, long>();

            string line;
            while ((line = Console.ReadLine()) != "report")
            {
                string[] infoForCountry = line.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                string county = infoForCountry[1];
                string city = infoForCountry[0];
                long population = long.Parse(infoForCountry[2]);

                if (!countries.ContainsKey(county))
                {
                    countries.Add(county, new Dictionary<string, long>());
                    countries[county].Add(city, population);
                    populationOfCountries.Add(county, population);
                }
                else
                {
                    if (!countries[county].ContainsKey(city))
                    {
                        countries[county].Add(city, population);
                        populationOfCountries[county] += population;
                    }
                }
            }
            var sortedByPopulationCountries = populationOfCountries.ToList();
            sortedByPopulationCountries.Sort((x1, x2) => x2.Value.CompareTo(x1.Value));
            foreach (var country in sortedByPopulationCountries)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                var sortedByPopulationCities = countries[country.Key].ToList();
                sortedByPopulationCities.Sort((x1, x2) => x2.Value.CompareTo(x1.Value));
                foreach (var city in sortedByPopulationCities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}