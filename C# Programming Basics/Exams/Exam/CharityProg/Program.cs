using System;


class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int bakers = int.Parse(Console.ReadLine());
        int cakes = int.Parse(Console.ReadLine());
        int wafles = int.Parse(Console.ReadLine());
        int pencake = int.Parse(Console.ReadLine());

        int cakesDay = cakes * 45;
        double waflesDay = wafles * 5.80;
        double pencakeDay = pencake * 3.20;
        double priceDay = ((cakesDay + waflesDay + pencakeDay) * bakers);
        double campaign = priceDay * days;
        double result = campaign - (campaign / 8);

        Console.WriteLine("{0:f2}", result);       
    }
}