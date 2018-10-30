using System;
using System.Collections;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stringReverser = new Stack<char>();

            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                stringReverser.Push(letter);
            }

            //while (stringReverser.Count > 0)
            //{
            //    Console.Write(stringReverser.Pop());
            //}

            foreach (char letter in stringReverser)
            {
                Console.Write(letter);
            }

            Console.WriteLine();
        }
    }
}
