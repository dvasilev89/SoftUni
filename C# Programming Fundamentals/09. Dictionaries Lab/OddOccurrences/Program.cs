using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> counts = new Dictionary<string, int>();

        List<string> num = Console.ReadLine().Trim().ToLower().Split().ToList();

        for (int i = 0; i < num.Count; i++)
        {
            if (counts.ContainsKey(num[i]) == false)
            {
                counts.Add(num[i], 0);
            }

            counts[num[i]]++;
        }

        List<string> oddNums = new List<string>();

        foreach (var number in counts)
        {
            if (number.Value % 2 != 0)
            {
                oddNums.Add(number.Key);
            }
        }

        Console.WriteLine(string.Join(", ", oddNums));
    }
}

