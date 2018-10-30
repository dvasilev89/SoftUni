using System;


class Program
{
    static void Main(string[] args)
    {
        string figureType = Console.ReadLine();

        double result = GetGeometryCalculation(figureType);

        Console.WriteLine("{0:f2}", result);
    }

    static double GetGeometryCalculation(string figureType)
    {
        double result = 0.0;

        if (figureType == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            result = ((side * height) / 2);
        }
        else if (figureType == "square")
        {
            double side = double.Parse(Console.ReadLine());

            result = Math.Pow(side, 2);
        }
        else if (figureType == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            result = width * height;
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());

            result = (Math.PI * Math.Pow(radius, 2));
        }

        return result;
    }
}