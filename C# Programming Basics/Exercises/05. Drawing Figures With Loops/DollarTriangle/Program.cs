using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int r = 0; r < n; r++)
        {

            Console.Write("$");

            for (int c = 0; c < r; c++)
            {
                Console.Write(" $");
            }
            Console.WriteLine();
        }
    }
}

