using System;


class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        double totalEnergy = (volume * 0.01) * energy;
        double totalSugar = (volume * 0.01) * sugar;

        Console.WriteLine("{0}ml {1}:", volume, product);
        Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
    }
}

