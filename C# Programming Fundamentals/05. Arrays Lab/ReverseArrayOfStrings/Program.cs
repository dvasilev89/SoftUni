using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split()
            .Select((e => e))
            .ToArray();

        Array.Reverse(input);

        Console.Write(string.Join(" ", input) + " ");

        //for (int i = input.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(string.Join(" ", input[i]) + " ");
        //}
        //Console.WriteLine();
    }
}

