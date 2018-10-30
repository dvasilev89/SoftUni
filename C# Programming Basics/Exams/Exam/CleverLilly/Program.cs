using System;




class Program
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toysCount = 0;
        int moneyCount = 0;
        int steelCount = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                moneyCount += i * 10 / 2;
                steelCount--;
            }
            else
            {
                toysCount++;
            }
        }

        int toysTotal = toysCount * toyPrice;
        int moneyTotal = toysTotal + moneyCount + steelCount;

        if (moneyTotal >= washingMachinePrice)
        {
            Console.WriteLine("Yes! {0:f2}", moneyTotal - washingMachinePrice);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", washingMachinePrice - moneyTotal);
        }

    }
}

