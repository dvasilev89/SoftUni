using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesContinentCountry
{
    class CitiesContinentCountry
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> book = new Dictionary<string, Dictionary<string, List<string>>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = input[0];
                string countrie = input[1];
                string city = input[2];

                if (book.ContainsKey(continent) == false)
                {
                    book.Add(continent, new Dictionary<string, List<string>>());
                }

                if (book[continent].ContainsKey(countrie) == false)
                {
                    book[continent].Add(countrie, new List<string>());
                }

                book[continent][countrie].Add(city);
            }

            foreach (var continent in book)
            {
                Console.WriteLine($"{continent.Key}:");

                Dictionary<string, List<string>> countrieBook = continent.Value;

                foreach (var item in countrieBook)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
