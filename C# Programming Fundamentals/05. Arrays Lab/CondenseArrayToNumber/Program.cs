using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split()
            .Select((e => int.Parse(e)))
            .ToArray();

        for (int i = input.Length - 1; i > 0 ; i--)
        {
            for (int j = 0; j < i; j++)
            {
                input[j] = input[j] + input[j + 1];
            }
                //Console.WriteLine(string.Join(" ", input));
        }

        Console.WriteLine(input[0]);
    }
}

