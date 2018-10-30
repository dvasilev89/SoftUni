using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = commands[0];
            int numbersToPop = commands[1];
            int numberToFind = commands[2];

            Stack<int> stack = new Stack<int>(numbersToPush);

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            bool isContained = stack.Contains(numberToFind);

            if (stack.Count < 1)
            {
                Console.WriteLine(stack.Count);
            }
            else if (isContained)
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestNumber = stack.Peek();

                foreach (int number in stack)
                {
                    int currentNumber = number;

                    if (currentNumber < smallestNumber)
                    {
                        smallestNumber = currentNumber;
                    }
                }

                Console.WriteLine(smallestNumber);
            }
        }
    }
}
