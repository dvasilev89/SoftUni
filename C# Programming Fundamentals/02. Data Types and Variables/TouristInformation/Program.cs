using System;



class Program
{
    static void Main(string[] args)
    {
        string imperialUnit = Console.ReadLine().ToLower();
        double value = double.Parse(Console.ReadLine());
        double firstValue = value;

        switch (imperialUnit)
        {
            case "miles": value *= 1.6; Console.WriteLine($"{firstValue} miles = {value:f2} kilometers"); break;
            case "inches": value *= 2.54; Console.WriteLine($"{firstValue} inches = {value:f2} centimeters"); break;
            case "feet": value *= 30; Console.WriteLine($"{firstValue} feet = {value:f2} centimeters"); break;
            case "yards": value *= 0.91; Console.WriteLine($"{firstValue} yards = {value:f2} meters"); break;
            case "gallons": value *= 3.8; Console.WriteLine($"{firstValue} gallons = {value:f2} liters"); break;
        }
    }
}

