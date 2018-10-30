using System;


class Program
{
    static void Main(string[] args)
    {

        int a = Math.Abs(int.Parse(Console.ReadLine()));
        int b = Math.Abs(int.Parse(Console.ReadLine()));

        while (b != 0)
        {
            int oldB = b;
            b = a % b;
            a = oldB;
        }

        Console.WriteLine(a);   
    }
}

