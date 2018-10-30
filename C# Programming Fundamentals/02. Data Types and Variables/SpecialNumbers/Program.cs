using System;


class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        int sum = 0;
        
        for (int i = 1; i <= n; i++)
        {
            sum = (i % 10) + (i / 10);

            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine("{0} -> True", i);
            }
            else
            {
                Console.WriteLine("{0} -> False", i);
            }
        }
    }
}

