using System;




class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("@" + new string(' ', n - 2) + "@" + new string(' ', n - 2) + "@");

        Console.WriteLine("**" + new string(' ', n - 3) + "*" + new string(' ', n - 3) + "**");        


        for (int i = 1, j = ((n * 2) - 10) / 2, k = 1; i <= n / 2 - 2; i++, j-=2, k+=2)
        {
            Console.Write("*" + new string('.', i) + "*" + new string(' ', Math.Max(j, 0)) + "*" + new string('.', k));

            Console.WriteLine("*" + new string(' ', Math.Max(j, 0)) + "*" + new string('.', i) + "*");
        }

        Console.Write("*" + new string('.', n / 2 - 1) + "*" + new string('.', n - 3) + "*");

        Console.WriteLine(new string('.', n / 2 - 1) + "*");

        Console.Write("*" + new string('.', n / 2) + new string('*', n / 2 - 2) + ".");

        Console.WriteLine(new string('*', n / 2 - 2) + new string('.', n / 2) + "*");

        Console.WriteLine(new string('*', 2 * n - 1));

        Console.WriteLine(new string('*', 2 * n - 1));
    }
}

