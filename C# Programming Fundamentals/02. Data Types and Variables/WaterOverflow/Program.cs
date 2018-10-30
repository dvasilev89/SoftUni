using System;



class Program
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());

        byte waterTankCapacity = byte.MaxValue;
        ushort littersSum = 0;

        for (int i = 1; i <= n; i++)
        {
            ushort liters = ushort.Parse(Console.ReadLine());
            littersSum += liters;
            
            if (littersSum > waterTankCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
                littersSum -= liters;
            }
        }
        Console.WriteLine(littersSum);
    }
}

