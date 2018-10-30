using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfComands; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int numberToPush = input[1];
                    stack.Push(numberToPush);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    if (stack.Count < 1 == false)
                    {
                        int biggestNumber = stack.Peek();

                        foreach (int num in stack)
                        {
                            if (num > biggestNumber)
                            {
                                biggestNumber = num;
                            }
                        }

                        Console.WriteLine(biggestNumber);
                    }
                }
            }
        }
    }
}
