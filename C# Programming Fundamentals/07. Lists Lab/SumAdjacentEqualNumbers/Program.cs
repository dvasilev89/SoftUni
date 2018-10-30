using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

        bool hasPairs = true;
        int count = input.Count - 1;
        while (hasPairs)
        {
            hasPairs = false;

            for (int k = 0; k < count; k++)
            {
                if (input[k] == input[k + 1])
                {
                    input[k] = input[k] + input[k + 1];
                    input.RemoveAt(k + 1);
                    count--;
                    hasPairs = true;
                }
            }
        }

        Console.WriteLine(string.Join(" ", input));
    }
}

