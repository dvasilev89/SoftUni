using System;


class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
              
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        if (LongerLine(x1, y1, x2, y2, x3, y3, x4, y4) == "first")
        {
            ClosestPoint(x1, y1, x2, y2);
        }
        else
        {
            ClosestPoint(x3, y3, x4, y4);
        }
    }

    static string LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        string longerLine = "";

        double firstLine = (Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2))) + (Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2)));
        double secondLine = (Math.Sqrt(Math.Pow(y3, 2) + Math.Pow(x3, 2))) + (Math.Sqrt(Math.Pow(y4, 2) + Math.Pow(x4, 2)));

        if (firstLine >= secondLine)
        {
            longerLine = "first";
        }
        else
        {
            longerLine = "second";
        }

        return longerLine;
    }

    static void ClosestPoint(double x1, double y1, double x2, double y2)
    {
        double firstPoint = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
        double secondPoint = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

        if (firstPoint <= secondPoint)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }
}