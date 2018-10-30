using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesArray
{
    class CountSameValuesArray
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> book = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double number = input[i];

                if (book.ContainsKey(number) == false)
                {
                    book.Add(number, 0);
                }

                book[number]++;
            }

            foreach (var num in book)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
