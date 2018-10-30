using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, long> totalPopulation = new Dictionary<string, long>();
        Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "report")
            {
                break;
            }

            string[] information = input.Split("|").ToArray();

            string city = information[0];
            string country = information[1];
            long cityPopulation = long.Parse(information[2]);
            
            if (totalPopulation.ContainsKey(country) == false)
            {
                totalPopulation.Add(country, 0);
                countriesAndCities.Add(country, new Dictionary<string, long>());
            }

            totalPopulation[country] += cityPopulation;
            countriesAndCities[country].Add(city, cityPopulation);            
        }

        foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value})");

            Dictionary<string, long> cities = countriesAndCities[country.Key].OrderByDescending(c => c.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var city in cities)
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }

        

    }
}