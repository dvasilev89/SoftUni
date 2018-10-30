using System;



class Program
{
    static void Main(string[] args)
    {
        double n1 = int.Parse(Console.ReadLine());
        double n2 = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();

        if (symbol == "+")
        {
            double result = n1 + n2;

            if (result % 2 == 0)
            {
                Console.WriteLine("{0} + {1} = {2} - even", n1, n2, result);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, result);
            }
        }
        else if (symbol == "-")
        {
            double result = n1 - n2;

            if (result % 2 == 0)
            {
                Console.WriteLine("{0} - {1} = {2} - even", n1, n2, result);
            }
            else
            {
                Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, result);
            }
        }
        else if (symbol == "*")
        {
            double result = n1 * n2;

            if (result % 2 == 0)
            {
                Console.WriteLine("{0} * {1} = {2} - even", n1, n2, result);
            }
            else
            {
                Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, result);
            }
        }
        else if (symbol == "/")
        {
            double result = n1 / n2;

            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
            }
        }
        else if (symbol == "%")
        {
            double result = n1 % n2;

            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
            }
        }
    }
}

