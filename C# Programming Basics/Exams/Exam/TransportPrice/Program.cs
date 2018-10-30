using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string duration = Console.ReadLine();

        if (duration == "day")
        {
            if (n < 20)
            {
                double price = (n * 0.79 + 0.70);
                Console.WriteLine("{0:f2}", price);
            }
            else if (n < 100)
            {
                double price = (n * 0.09);
                Console.WriteLine("{0:f2}", price);
            }
            else if (n < 5000)
            {
                double price = (n * 0.06);
                Console.WriteLine("{0:f2}", price);
            }
        }
        if (duration == "night")
        {
            if (n < 20)
            {
                double price = (n * 0.9 + 0.70);
                Console.WriteLine("{0:f2}", price);
            }
            else if (n < 100)
            {
                double price = (n * 0.09);
                Console.WriteLine("{0:f2}", price);
            }
            else if (n < 5000)
            {
                double price = (n * 0.06);
                Console.WriteLine("{0:f2}", price);
            }
        }
    }
}

