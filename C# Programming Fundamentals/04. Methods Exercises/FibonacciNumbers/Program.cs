using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int result = GetFibonacci(n);

        Console.WriteLine(result);
    }

    static int GetFibonacci(int n)
    {
        int f0 = 1;
        int f1 = 1;

        for (int i = 0; i <= n - 2; i++)
        {
            int fNext = f0 + f1;
            f0 = f1;
            f1 = fNext;
        }        

        return f1;
    }
}

