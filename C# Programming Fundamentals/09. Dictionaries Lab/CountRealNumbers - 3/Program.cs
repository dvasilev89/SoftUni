using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        List<double> num = Console.ReadLine().Split().Select(double.Parse).ToList();

        for (int i = 0; i < num.Count; i++)
        {
            if (counts.ContainsKey(num[i]) == false)
            {
                counts.Add(num[i], 1);
            }
            else
            {
                counts[num[i]] += 1;
            }

        }

        foreach (var number in counts)
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}

