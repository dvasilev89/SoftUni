using System;


class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        ClosestPoint(x1, y1, x2, y2);
    }

    static void ClosestPoint(int x1, int y1, int x2, int y2)
    {
        double firstPoint = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
        double secondPoint = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

        if (firstPoint <= secondPoint)
        {
            Console.WriteLine("({0}, {1})", x1, y1);
        }
        else
        {
            Console.WriteLine("({0}, {1})", x2, y2);
        }
    }
}