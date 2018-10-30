using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        double[] n = Console.ReadLine().Split()
            .Select((e => double.Parse(e)))
            .ToArray();

        foreach (double num in n)
        {
            int numRounded = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num} => {numRounded}");
        }        
    }
}

