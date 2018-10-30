using System;



class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int a = 0;
        int result = 0;

        while (num != 0)
        {
            a = num % 10;
            result += a;
            num = num / 10;
        }

        Console.WriteLine(result);
    }
}

