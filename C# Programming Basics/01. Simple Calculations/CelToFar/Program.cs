using System;


class Program
{
    static void Main(string[] args)
    {
        double celsium = double.Parse(Console.ReadLine());
        double fahren = Math.Round((celsium * 1.8 + 32), 2);

        Console.WriteLine(fahren);
    }
}