using System;


class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double side = double.Parse(Console.ReadLine());

        double hall = (lenght * 100) * (width * 100);
        double furniture = (side * 100) * (side * 100);
        double bench = hall / 10;
        double space = hall - furniture - bench;
        double result = Math.Floor(space / (40 + 7000));

        Console.WriteLine(result);
    }
}