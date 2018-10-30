using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();

            int numberOfPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(input);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (int[] currentPetrolPump in petrolPumps)
                {
                    int fuel = currentPetrolPump[0];
                    int distance = currentPetrolPump[1];

                    totalFuel += (fuel - distance);

                    if (totalFuel < 0)
                    {
                        index++;
                        int[] pumpForRemove = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(pumpForRemove);
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
