using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Trim()
            .Split()
            .Select(x => int.Parse(x))
            .ToList();

        int[] threeNumbers = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToArray();

        numbers.RemoveRange(threeNumbers[0], numbers.Count - threeNumbers[0]);
        numbers.RemoveRange(0, threeNumbers[1]);

        bool isNumberInList = numbers.Any(x => x == threeNumbers[2]);

        if (isNumberInList)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }

    }
}

