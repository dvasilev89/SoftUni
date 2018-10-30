using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int count = 0;
            string command = "";

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command == "green")
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
