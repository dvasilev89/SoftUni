using System;


class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int oldA = a;

        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);

        a = b;
        b = oldA;

        Console.WriteLine("After:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}

