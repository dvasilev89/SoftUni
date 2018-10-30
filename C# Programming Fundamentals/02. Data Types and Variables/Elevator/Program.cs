using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int fullCurses = (int) (Math.Ceiling((double)n / p));

        Console.WriteLine(fullCurses);
    }
}

