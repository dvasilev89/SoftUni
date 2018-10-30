using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            Stack<int> numberReverser = new Stack<int>(input.Length);

            foreach (int number in input)
            {
                numberReverser.Push(number);
            }

            foreach (int number in numberReverser)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
