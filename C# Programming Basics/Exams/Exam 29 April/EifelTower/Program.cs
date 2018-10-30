using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('-', n + 2) + "**" + new string('-', n + 2));
        }

        for (int i = 1; i <= n - 3; i++)
        {
            Console.WriteLine(new string('-', n + 1) + "****" + new string('-', n + 1));
        }

        Console.WriteLine(new string('-', n) + "******" + new string('-', n));

        for (int i = 1; i <= n - 4; i++)
        {
            Console.WriteLine(new string('-', n) + "**--**" + new string('-', n));
        }

        for (int i = 1; i <= n - 3; i++)
        {
            Console.WriteLine(new string('-', n - 1) + "**----**" + new string('-', n - 1));
        }

        Console.WriteLine(new string('-', n - 2) + "**********" + new string('-', n - 2));

        for (int i = n - 3, j = 8; i >= 1; i--, j+=2)
        {
            Console.WriteLine(new string('-', i) + "**" + new string('-', j) + "**" + new string('-', i));
        }

        Console.WriteLine("***" + new string('-', n * 2) + "***");
    }
}

