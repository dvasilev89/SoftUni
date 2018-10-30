using System;


class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());

        int totalDistance = 384400 * 2;

        double time = Math.Ceiling(totalDistance / x);
        double totalTime = time + 3;

        double fuel = ((n * totalDistance) / 100);

        Console.WriteLine(totalTime);
        Console.WriteLine(fuel);
    }
}

