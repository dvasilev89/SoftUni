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
                for (int i = n / 2 - 1, j = 1; j <= (n / 2); i--, j++)
                {
                    Console.WriteLine(new string('-', i) + new string('*', j) + new string('*', j) + new string('-', i));
                }
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine("|" + new string('*', n-2) + "|");
                }
            }
            else
            {
                for (int i = (n - 1) / 2, j = 1; j <= n; i--, j+=2)
                {
                    Console.WriteLine(new string('-', i) + new string('*', j) + new string('-', i));
                }
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine("|" + new string('*', n - 2) + "|");
                }
            }
        }
        else if (n == 2)
        {
            Console.WriteLine("**");
            Console.WriteLine("||");
        }
         
    }
}