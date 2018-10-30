using System;



class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = squareSide * squareSide;

            Console.WriteLine("{0:f3}", squareArea);
        }
        else if (figure == "rectangle")
        {
            double rectangleSideA = double.Parse(Console.ReadLine());
            double rectangleSideB = double.Parse(Console.ReadLine());
            double rectangleArea = rectangleSideA * rectangleSideB;

            Console.WriteLine("{0:f3}", rectangleArea);
        }
        else if (figure == "circle")
        {
            double circleRadius = double.Parse(Console.ReadLine());            
            double circleArea = Math.PI * circleRadius * circleRadius;

            Console.WriteLine("{0:f3}", circleArea);
        }
        else if (figure == "triangle")
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHight = double.Parse(Console.ReadLine());
            double triangleArea = triangleSide * triangleHight / 2;

            Console.WriteLine("{0:f3}", triangleArea);
        }
    }
}

