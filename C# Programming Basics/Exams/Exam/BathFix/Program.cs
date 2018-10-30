using System;


class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double W = double.Parse(Console.ReadLine());
        double L = double.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int O = int.Parse(Console.ReadLine());

        int totalArea = N * N;
        int benchArea = M * O;
        int coverArea = totalArea - benchArea;
        double bathArea = W * L;
        double bathNes = coverArea / bathArea;
        double time = bathNes * 0.2;

        Console.WriteLine("{0:f2}", bathNes);
        Console.WriteLine("{0:f2}", time);    
    }
}