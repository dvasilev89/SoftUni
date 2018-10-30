using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());

        if (t > 10)
        {
            for (int i = t; i <= t; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
            }
        }
        else
        {
            for (int i = t; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
            }
        }        
    }
}

