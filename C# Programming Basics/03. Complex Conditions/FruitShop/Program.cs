using System;




class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        bool dayWeek = (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday");
        bool weekend = (day == "saturday" || day == "sunday");        

        if (dayWeek)
        {
            if (product == "banana") Console.WriteLine("{0:f2}", quantity * 2.50);
            else if (product == "apple") Console.WriteLine("{0:f2}", quantity * 1.20);
            else if (product == "orange") Console.WriteLine("{0:f2}", quantity * 0.85);
            else if (product == "grapefruit") Console.WriteLine("{0:f2}", quantity * 1.45);
            else if (product == "kiwi") Console.WriteLine("{0:f2}", quantity * 2.70);
            else if (product == "pineapple") Console.WriteLine("{0:f2}", quantity * 5.50);
            else if (product == "grapes") Console.WriteLine("{0:f2}", quantity * 3.85);
            else Console.WriteLine("error");
        }
        else if (weekend)
        {
            if(product == "banana") Console.WriteLine("{0:f2}", quantity * 2.70);
            else if (product == "apple") Console.WriteLine("{0:f2}", quantity * 1.25);
            else if (product == "orange") Console.WriteLine("{0:f2}", quantity * 0.90);
            else if (product == "grapefruit") Console.WriteLine("{0:f2}", quantity * 1.60);
            else if (product == "kiwi") Console.WriteLine("{0:f2}", quantity * 3.00);
            else if (product == "pineapple") Console.WriteLine("{0:f2}", quantity * 5.60);
            else  if (product == "grapes") Console.WriteLine("{0:f2}", quantity * 4.20);
            else Console.WriteLine("error");
        }
        else
            Console.WriteLine("error");
    }
}