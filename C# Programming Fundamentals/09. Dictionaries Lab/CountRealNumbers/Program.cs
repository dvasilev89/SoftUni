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


        bool wasManip = true;

        while (wasManip)
        {
            wasManip = false;
            for (int i = 0; i < input.Count - 1; i++)
            {
                double currentNum = input[i];
                double nextNum = input[i + 1];

                if (currentNum > nextNum)
                {
                    input[i] = nextNum;
                    input[i + 1] = currentNum;
                    wasManip = true;
                }

            }

        }

        int counter = 1;
        double current = input[0];

        for (int i = 1; i < input.Count; i++)
        {
            double nextNum = input[i];

            if (current == nextNum)
            {
                counter++;
            }
            else
            {
                Console.WriteLine($"{current} -> {counter}");
                counter = 1;
                current = input[i];
            }
        }
        Console.WriteLine($"{current} -> {counter}");        
    }
}

