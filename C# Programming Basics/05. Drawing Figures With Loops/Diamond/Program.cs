using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 3)
        {
            if (n % 2 == 0)
            {
                for (int i = n / 2 - 1, j = 0; j <= (n / 2) - 1; i--, j++)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', j) + new string('-', j) + "*" + new string('-', i));
                }
                for (int i = 1, j = n / 2 - 2; i <= (n / 2) - 1; i++, j--)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', j) + new string('-', j) + "*" + new string('-', i));
                }
            }
            else
            {
                Console.WriteLine(new string('-', (n -1) / 2) + "*" + new string('-', (n - 1) / 2));

                for (int i = (n - 3) / 2, j = 1; j <= n - 2; i--, j += 2)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', j) + "*" + new string('-', i));
                }
                for (int i = 1, j = n - 4; i <= (n - 3) / 2; i++, j -= 2)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', j) + "*" + new string('-', i));
                }

                Console.WriteLine(new string('-', (n - 1) / 2) + "*" + new string('-', (n - 1) / 2));
            }
        }
        else if (n == 2)
        {
            Console.WriteLine("**");
        }
        else
        {
            Console.WriteLine("*");
        }
    }
}

