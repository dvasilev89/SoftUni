using System;


class Program
{
    static void Main(string[] args)
    {
        double sideA = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        double area = GetTriangleArea(sideA, hight);
        Console.WriteLine(area);
    }

    static double GetTriangleArea(double sideA, double hight)
    {
        return (sideA * hight) / 2;
    }
}

