using System;


class Program
{
    static void Main(string[] args)
    {
        int videoPrice = int.Parse(Console.ReadLine());
        int adapterPrice = int.Parse(Console.ReadLine());
        double dailyEnergyConsumed = double.Parse(Console.ReadLine());
        double dailyVideoProfit = double.Parse(Console.ReadLine());

        int totalExpences = ((videoPrice * 13) + (adapterPrice * 13) + 1000);
        double totalDailyProfit = 13 * (dailyVideoProfit - dailyEnergyConsumed);

        double moneyReturn = Math.Ceiling(totalExpences / totalDailyProfit);

        Console.WriteLine(totalExpences);
        Console.WriteLine(moneyReturn);
    }
}

