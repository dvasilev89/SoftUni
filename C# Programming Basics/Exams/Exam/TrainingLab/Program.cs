using System;



class Program
{
    static void Main(string[] args)
    {
        double l = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());

        double places = Math.Floor(l / 1.2);
        double rowPlaces = Math.Floor((w - 1) / 0.7);

        Console.WriteLine((rowPlaces * places) - 3);


    }
}

