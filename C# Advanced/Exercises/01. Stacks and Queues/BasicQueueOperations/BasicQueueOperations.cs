using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int add = command[0];
            int delete = command[1];
            int find = command[2];

            Queue<int> queue = new Queue<int>(add);

            for (int i = 0; i < add; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < delete; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count < 1)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(find))
            {
                Console.WriteLine("true");
            }
            else if (queue.Contains(find) == false)
            {
                int smallestNumber = queue.Peek();

                foreach (int number in queue)
                {
                    if (number < smallestNumber)
                    {
                        smallestNumber = number;
                    }
                }

                Console.WriteLine(smallestNumber);
            }
        }
    }
}
