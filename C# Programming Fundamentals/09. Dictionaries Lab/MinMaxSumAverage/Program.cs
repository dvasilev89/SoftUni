using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        double sum = 0.0;
        double average = 0.0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()); 
            sum += numbers[i];
        }
        average = sum / n;

        
        int minNumber = numbers[0];
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }

            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Min = {0}", minNumber);
        Console.WriteLine("Max = {0}", maxNumber);
        Console.WriteLine("Average = {0}", average);        
    }   
}

