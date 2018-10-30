using System;


class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
    }

    static bool IsPrime(long n)
    {
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime && n > 2)
        {
            isPrime = true;
        }
        else
        {
            isPrime = false;
        }

        return isPrime;
    }
}

