using System;


class Program
{
    static void Main(string[] args)
    {
        int tables = int.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double curtainArea = tables * (lenght + 2 * 0.30) * (width + 2 * 0.30);
        double kareArea = tables * (lenght / 2) * (lenght / 2);

        double usd = (curtainArea * 7 + kareArea * 9);
        double bgn = (usd * 1.85);

        Console.WriteLine("{0:f2} USD", usd);
        Console.WriteLine("{0:f2} BGN", bgn);
    }
}

