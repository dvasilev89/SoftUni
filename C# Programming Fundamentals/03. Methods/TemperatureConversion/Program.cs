using System;


class Program
{
    static void Main(string[] args)
    {
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine("{0:f2}", celsius);
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

