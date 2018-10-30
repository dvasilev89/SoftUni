using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = input.OrderByDescending(x => x).ToList();

        if (result.Count < 3)
        {
            Console.WriteLine(string.Join(" ", result));
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

