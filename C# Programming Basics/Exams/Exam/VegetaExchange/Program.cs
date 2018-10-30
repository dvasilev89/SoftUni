using System;




class Program
{
    static void Main(string[] args)
    {
        double vegPrice = double.Parse(Console.ReadLine());
        double fruitPrice = double.Parse(Console.ReadLine());
        int vegKilos = int.Parse(Console.ReadLine());
        int fruitKilos = int.Parse(Console.ReadLine());

        double total = (vegPrice * vegKilos) + (fruitPrice * fruitKilos);
        double result = total / 1.94;

        Console.WriteLine(result);
    }
}

