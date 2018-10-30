using System;




class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        if (city == "sofia")
        {
            if (product == "coffee") Console.WriteLine(0.50 * quantity);
            if (product == "water") Console.WriteLine(0.80 * quantity);
            if (product == "beer") Console.WriteLine(1.20 * quantity);
            if (product == "sweets") Console.WriteLine(1.45 * quantity);
            if (product == "peanuts") Console.WriteLine(1.60 * quantity);
        }
        if (city == "plovdiv")
        {
            if (product == "coffee") Console.WriteLine(0.40 * quantity);
            if (product == "water") Console.WriteLine(0.70 * quantity);
            if (product == "beer") Console.WriteLine(1.15 * quantity);
            if (product == "sweets") Console.WriteLine(1.30 * quantity);
            if (product == "peanuts") Console.WriteLine(1.50 * quantity);
        }
        if (city == "varna")
        {
            if (product == "coffee") Console.WriteLine(0.45 * quantity);
            if (product == "water") Console.WriteLine(0.70 * quantity);
            if (product == "beer") Console.WriteLine(1.10 * quantity);
            if (product == "sweets") Console.WriteLine(1.35 * quantity);
            if (product == "peanuts") Console.WriteLine(1.55 * quantity);
        }
    }
}

