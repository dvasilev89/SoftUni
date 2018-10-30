using System;




class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', 2*n) + new string(' ', n) + new string('*', 2 * n));

        int nose = 0;

        if (n < 5)
        {
            nose++;
        }
        else
        {
            nose = (int)Math.Ceiling((n-2) / 2.0);
        }

        for (int i = 1; i <= n - 2; i++)
        {
            if (i == nose)
            {
                Console.WriteLine("*" + new string('/', (2 * n - 2)) + "*" + new string('|', n) + "*" + new string('/', (2 * n - 2)) + "*");
            }
            else
            {
                Console.WriteLine("*" + new string('/', (2 * n - 2)) + "*" + new string(' ', n) + "*" + new string('/', (2 * n - 2)) + "*");
            }
        }






        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
    }
}

