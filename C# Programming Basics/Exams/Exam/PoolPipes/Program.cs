using System;




class Program
{
    static void Main(string[] args)
    {
        int v = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double y = p1 * h;
        double z = p2 * h;
        double x = y + z;

        double yPer = Math.Floor(((x - y) / x) * 100);
        double zPer = Math.Floor(((x - z) / x) * 100);
        double xPer = Math.Floor(x / v * 100);

        if (x <= v)
        {
            Console.WriteLine("The pool is {0:0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", xPer, zPer, yPer);
        }
        else
        {
            double overLiters = -(v - x);
            Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", h, overLiters);
        }
    }
}

