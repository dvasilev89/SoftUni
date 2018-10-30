using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            

            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (!IsSquare(input[i]))
                {
                    input.RemoveAt(i);
                }
            }

            input.Sort();
            input.Reverse();
            Console.WriteLine(string.Join(" ", input));
        }

        private static bool IsSquare(int number)
        {
            double temp = Math.Sqrt(number);

            if (temp % 1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
