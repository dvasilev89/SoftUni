using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        PrintHeaderRow(n);
        PrintMiddleRow(n);
        PrintMiddleRow(n);
        PrintHeaderRow(n);
    }

    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void PrintMiddleRow(int n)
    {        
        Console.Write('-');

        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine('-');        
    }
}

