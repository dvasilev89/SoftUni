using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < input.Count; i++)
        {
            input[i] = ReverseInt(input[i]);
        }

        int sum = 0;
        foreach (int number in input)
        {
            sum += number;
        }

        Console.WriteLine(sum);        
    }

    static public int ReverseInt(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
}

