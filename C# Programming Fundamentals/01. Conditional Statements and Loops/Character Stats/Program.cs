using System;



class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maximumHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maximumEnergy = int.Parse(Console.ReadLine());

        int totalHealth = maximumHealth - currentHealth;
        int totalEnergy = maximumEnergy - currentEnergy;

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |" + new string('|', currentHealth) + new string('.', totalHealth) + "|");
        Console.WriteLine("Energy: |" + new string('|', currentEnergy) + new string('.', totalEnergy) + "|");
    }
}

