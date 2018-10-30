using System;
using System.Linq;

namespace AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (double price in prices)
            {
                Console.WriteLine("{0:f2}", price);
            }
        }
    }
}
