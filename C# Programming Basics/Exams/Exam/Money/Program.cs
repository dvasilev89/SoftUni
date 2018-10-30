using System;



class Program
{
    static void Main(string[] args)
    {
        int bitcoin = int.Parse(Console.ReadLine());
        double yen = double.Parse(Console.ReadLine());
        double comision = double.Parse(Console.ReadLine());

        double bitEuro = bitcoin * 1168 / 1.95;
        double yenEuro = yen * 0.15 * 1.76 / 1.95;
        double comisionTotal = comision * (bitEuro + yenEuro) / 100;

        double result = (bitEuro + yenEuro) - comisionTotal;

        Console.WriteLine("{0:f2}", result);
    }
}

