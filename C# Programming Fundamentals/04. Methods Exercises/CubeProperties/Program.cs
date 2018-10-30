using System;


class Program
{
    static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());  
        string calculate = Console.ReadLine();

        double result = GetCubeCalculation(side, calculate);

        Console.WriteLine("{0:f2}", result);
    }

    private static double GetCubeCalculation(double side, string calculate)
    {
        double result = 0.0;

        if (calculate == "face")
        {
            result = Math.Sqrt(2 * Math.Pow(side, 2));
        }
        else if (calculate == "space")
        {
            result = Math.Sqrt(3 * Math.Pow(side, 2));
        }
        else if (calculate == "volume")
        {
            result = Math.Pow(side, 3);
        }
        else if (calculate == "area")
        {
            result = (6 * Math.Pow(side, 2));
        }

        return result;
    }
}

