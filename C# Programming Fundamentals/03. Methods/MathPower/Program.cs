using System;


class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());        
        Console.WriteLine(GetNumber(num, power));
    }

    static double GetNumber(int num, int power)
    {
        return Math.Pow(num, power);
    }
}