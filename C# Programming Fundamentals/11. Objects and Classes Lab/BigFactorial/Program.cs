using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}

