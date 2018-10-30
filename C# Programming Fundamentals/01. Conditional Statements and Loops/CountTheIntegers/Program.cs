using System;


class Program
{
    static void Main(string[] args)
    {
        int result = 0;

        for (int i = 1; i <= 100; i++)
        {
            bool n = int.TryParse(Console.ReadLine(), out result);

            if (!n)
            {
                Console.WriteLine(i - 1);
                break;
            }           
        }        
    }
}

