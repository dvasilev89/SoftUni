using System;


class Program
{
    static void Main(string[] args)
    {
        string planet = Console.ReadLine().ToLower();
        int days = int.Parse(Console.ReadLine());
        
        if (planet == "mercury")
        {
            if (days <= 7)
            {
                double distance = 2 * 0.61;
                double totalDays = 2 * (226 * 0.61) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else if (planet == "venus")
        {
            if (days <= 14)
            {
                double distance = 2 * 0.28;
                double totalDays = 2 * (226 * 0.28) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else if (planet == "mars")
        {
            if (days <= 20)
            {
                double distance = 2 * 0.52;
                double totalDays = 2 * (226 * 0.52) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else if (planet == "jupiter")
        {
            if (days <= 5)
            {
                double distance = 2 * 4.2;
                double totalDays = 2 * (226 * 4.2) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else if (planet == "saturn")
        {
            if (days <= 3)
            {
                double distance = 2 * 8.52;
                double totalDays = 2 * (226 * 8.52) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else if (planet == "uranus")
        {
            if (days <= 3)
            {
                double distance = 2 * 18.21;
                double totalDays = 2 * (226 * 18.21) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else if (planet == "neptune")
        {
            if (days <= 2)
            {
                double distance = 2 * 29.09;
                double totalDays = 2 * (226 * 29.09) + days;

                Console.WriteLine("Distance: {0:f2}", distance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
            else
                Console.WriteLine("Invalid number of days!");
        }
        else
            Console.WriteLine("Invalid planet name!");
    }
}