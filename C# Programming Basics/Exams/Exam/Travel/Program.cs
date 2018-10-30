using System;



class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        if (money <= 100)
        {
            if (season == "summer")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", (money * 0.3));
            }
            else if (season == "winter")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", (money * 0.7));
            }
        }
        else if (money <= 1000)
        {
            if (season == "summer")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", (money * 0.4));
            }
            else if (season == "winter")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", (money * 0.8));
            }
        }
        else if (money > 1000)
        {
            Console.WriteLine("Somewhere in Europe");
            Console.WriteLine("Hotel - {0:f2}", (money * 0.9));
        }
    }
}

