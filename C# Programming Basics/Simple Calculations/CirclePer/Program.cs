using System;


class Program
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        var area = Math.PI * r * r;
        var perimeter = 2 * Math.PI * r;

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}