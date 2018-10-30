using System;


class Program
{
    static void Main(string[] args)
    {
        int lenght = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int hight = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        int cubic = lenght * width * hight;
        double allliters = cubic * 0.001;
        double realpercent = percent * 0.01;
        double result = (allliters * (1 - realpercent));       

        Console.WriteLine("{0:f3}", result);
    }
}

