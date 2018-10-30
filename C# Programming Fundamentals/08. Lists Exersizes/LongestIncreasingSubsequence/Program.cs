using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = "1 2 5 3 5 2 4 1 "
            .Trim()
            .Split()
            .Select(x => int.Parse(x))
            .ToList();

        List<int> result = new List<int>();

        int currentNum = 0;
        int lastNum = 0;
        

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            currentNum = numbers[i];
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

