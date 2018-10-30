using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, double>> barIncome = new Dictionary<string, Dictionary<string, double>>();
        double totalIncome = 0.0;


        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end of shift")
            {
                break;
            }

            string regex = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>[0-9]+)\|[^|$%.]*(?<price>[0-9]+\.?[0-9]+)\$";

            MatchCollection users = Regex.Matches(input, regex);

            string[] validUsers = users
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();


            string customer = validUsers[0];
            string product = validUsers[1];
            int count = 0;
            double price = 0.0;

            bool ifCount = int.TryParse(validUsers[2], out count);
            bool ifPrice = double.TryParse(validUsers[3], out price);

            if (ifCount == false)
            {
                continue;
            }
            if (ifPrice == false)
            {
                continue;
            }

            double totalPrice = count * price;

            barIncome.Add(customer, new Dictionary<string, double>());
            barIncome[customer].Add(product, totalPrice);

            totalIncome += totalPrice;
        }

        foreach (var customer in barIncome)
        {
            Dictionary<string, double> barValues = customer.Value.ToDictionary(x => x.Key, x => x.Value);
            foreach (var value in barValues)
            {
                Console.WriteLine($"{customer.Key}: {value.Key} - {value.Value:f2}");
            }
        }

        Console.WriteLine("Total income: {0:f2}", totalIncome);
    }
}

