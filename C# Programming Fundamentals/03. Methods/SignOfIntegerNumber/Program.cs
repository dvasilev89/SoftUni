using System;


class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        PrintSign(input);
    }

    static void PrintSign(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"The number {num} is positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"The number {num} is negative.");
        }
        else
        {
            Console.WriteLine($"The number {num} is zero.");
        }
    }    
}


