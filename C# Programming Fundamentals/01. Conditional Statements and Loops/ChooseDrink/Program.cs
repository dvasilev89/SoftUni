using System;



class Program
{
    static void Main(string[] args)
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        double totalPrice = 0.0;

        switch (profession)
        {
            case "Athlete": totalPrice += 0.70; break;
            case "Businessman": totalPrice += 1.00; break;
            case "Businesswoman": totalPrice += 1.00; break;
            case "SoftUni Student": totalPrice += 1.70; break;
            default: totalPrice += 1.20; break;
        }
        totalPrice = quantity * totalPrice;

        Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalPrice);
    }
}


