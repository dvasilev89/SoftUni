using System;


class Program
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int max = GetMax(firstNum, secondNum);
        max = Math.Max(max, thirdNum);

        Console.WriteLine(max);
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
}

