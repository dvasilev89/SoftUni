using System;


class Program
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());
        string biggestKeg = "";
        double result = 0.0;

        for (int i = 1; i <= n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            
            if (volume > result)
            {
                result = volume;
                biggestKeg = model;
            }            
        }

        Console.WriteLine(biggestKeg);
    }
}


