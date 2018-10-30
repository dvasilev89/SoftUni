using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.Write("Square = ");
        Console.WriteLine(area);       
    }
}