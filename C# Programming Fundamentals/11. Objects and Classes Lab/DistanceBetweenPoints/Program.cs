using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        double distance = CalcDistance(p1, p2);

        Console.WriteLine("{0:f3}", distance);
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

