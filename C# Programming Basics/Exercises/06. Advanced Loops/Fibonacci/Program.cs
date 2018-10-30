using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int f0 = 1;
        int f1 = 1;

        for (int i = 0; i <= n - 2; i++)
        {
            int fNext = f0 + f1;
            f0 = f1;
            f1 = fNext;
        }

        Console.WriteLine(f1);
    }
}

