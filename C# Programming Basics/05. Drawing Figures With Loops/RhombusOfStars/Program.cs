using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int r = 1; r <= n; r++)
        {            
            for (int c = 1; c <= (n - r); c++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int c = 1; c < r; c++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();            
        }

        for (int r = 1; r <= n - 1; r++)
        {
            for (int c = 1; c < r; c++)
            {
                Console.Write(" ");
            }
            Console.Write(" *");

            for (int c = 1; c < (n - r); c++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}

