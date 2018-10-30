using System;



class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());

        double area = width * hight;

        Console.WriteLine("{0:f2}", area);
    }
}

