using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Point[] allPoints = new Point[n];

        for (int i = 0; i < n; i++)
        {
            allPoints[i] = ReadPoint();
        }        

        double shorterDistance = CalcDistance(allPoints[0], allPoints[1]);
        Point[] result = new Point[2];
        result[0] = allPoints[0];
        result[1] = allPoints[1];

        for (int i = 0; i < n; i++)
        {
            for (int k = i + 1; k < n; k++)
            {
                double currentDistance = CalcDistance(allPoints[i], allPoints[k]);

                if (currentDistance < shorterDistance)
                {
                    shorterDistance = currentDistance;
                    result[0] = allPoints[i];
                    result[1] = allPoints[k];
                }
            }            
        }

        Console.WriteLine("{0:f3}", shorterDistance);

        foreach (var point in result)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }    

    static Point ReadPoint()
    {
        int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Point point = new Point();
        point.X = pointInfo[0];
        point.Y = pointInfo[1];
        return point;
    }

    static double CalcDistance(Point p1, Point p2)
    {
        int deltaX = p1.X - p2.X;
        int deltaY = p1.Y - p2.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
