using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];        

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());            
        }

        int min = numbers.Min();
        int max = numbers.Max();
        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Average = {0}", average);
    }
}

