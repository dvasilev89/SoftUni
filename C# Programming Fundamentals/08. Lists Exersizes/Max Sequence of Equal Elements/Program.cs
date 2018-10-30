using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();


        int start = 0;
        int length = 1;
        int bestStart = input[0];
        int bestLength = 1;

        for (int i = 0; i < input.Count - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                start = input[i];
                length++;
            }
            else
            {
                length = 1;
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        Console.WriteLine(string.Join(" ", input.FindAll(x => x == bestStart)));
    }
}

