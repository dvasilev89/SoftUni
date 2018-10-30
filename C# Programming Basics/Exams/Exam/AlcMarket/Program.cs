using System;


class Program
{
    static void Main(string[] args)
    {
        double wiskipr = double.Parse(Console.ReadLine());
        double beerl = double.Parse(Console.ReadLine());
        double winel = double.Parse(Console.ReadLine());
        double rakiql = double.Parse(Console.ReadLine());
        double wiskil = double.Parse(Console.ReadLine());

        double rakiqlpr = wiskipr / 2;
        double winelpr = rakiqlpr - (0.4 * rakiqlpr);
        double beerlpr = rakiqlpr - (0.8 * rakiqlpr);

        double rakiqCost = rakiql * rakiqlpr;
        double wineCost = winel * winelpr;
        double beerCost = beerl * beerlpr;
        double wiskiCost = wiskil * wiskipr;
        double result = rakiqCost + wineCost + beerCost + wiskiCost;

        Console.WriteLine(("{0:f2}"), result);
    }
}