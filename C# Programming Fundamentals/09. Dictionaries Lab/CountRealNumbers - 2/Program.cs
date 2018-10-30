using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<double> input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();


        input.Sort();

        List<double> numbers = new List<double>();
        List<int> count = new List<int>();

        foreach (double num in input)
        {
            if (numbers.Contains(num) == false)
            {
                numbers.Add(num);
                count.Add(1);
            }
            else
            {
                int index = numbers.IndexOf(num);
                count[index]++;
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"{numbers[i]} -> {count[i]}");
        }
    }
}

