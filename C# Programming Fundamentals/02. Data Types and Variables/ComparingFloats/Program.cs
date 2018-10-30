using System;


class Program
{
    static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        float eps = 0.000001f;

        double difference = Math.Abs((Math.Max(num1, num2) - Math.Min(num1, num2)));

        if (difference < eps)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }        
    }
}

