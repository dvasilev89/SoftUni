using System;



class Program
{
    static void Main(string[] args)
    {

        double foodMoney = double.Parse(Console.ReadLine());
        double junkMoney = double.Parse(Console.ReadLine());
        double hotelMoney = double.Parse(Console.ReadLine());

        double moneySpend = 0.0;

        moneySpend = 29.4;
        moneySpend *= 1.85;
        moneySpend += 3 * foodMoney + 3 * junkMoney;
        moneySpend += hotelMoney * 0.9 + hotelMoney * 0.85 + hotelMoney * 0.8;



        Console.WriteLine("Money needed: {0:f2}", moneySpend);

    }
}

