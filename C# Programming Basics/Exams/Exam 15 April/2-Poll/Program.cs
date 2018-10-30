using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int a = (int)(x - (x * 0.2));
        int b = (int)(a - (a * 0.1));

        int total = (x + a + b);

        if (total >= (n / 2))
        {
            int votes = total - (n / 2);
            Console.WriteLine("First three languages have {0} votes more", votes);
        }
        else
        {
            int votes = (n / 2) - total;
            Console.WriteLine("First three languages have {0} votes less of half votes", votes);
        }
    }
}

