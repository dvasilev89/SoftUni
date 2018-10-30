using System;


class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:X}", input);

        Console.WriteLine(Convert.ToString(input, 2));        
    }
}

