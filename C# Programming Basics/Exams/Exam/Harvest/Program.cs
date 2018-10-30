using System;



class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double grapesTotal = x * y;
        double wineLiters = (grapesTotal * 0.4) / 2.5;

        if (wineLiters >= z)
        {
            double litersLeft = Math.Ceiling(wineLiters - z);
            double litersPerWorker = Math.Ceiling(litersLeft / workers);
            double roundWineLiters = Math.Floor(wineLiters);

            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", roundWineLiters);
            Console.WriteLine("{0} liters left -> {1} liters per person.", litersLeft, litersPerWorker);
        }
        else if (wineLiters < z)
        {
            double wineNeeded = Math.Floor(z - wineLiters);

            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", wineNeeded);
        }
    }
}

