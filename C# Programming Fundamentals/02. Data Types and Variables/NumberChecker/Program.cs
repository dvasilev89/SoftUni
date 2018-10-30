using System;


class Program
{
    static void Main(string[] args)
    {
        bool input = long.TryParse(Console.ReadLine(), out long a);
        
        if (input)
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("floating-point");
        }
    }
}

