using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicals = new SortedSet<string>();

            int chemicalsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < chemicalsNumber; i++)
            {
                string[] chemicalsToAdd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < chemicalsToAdd.Length; j++)
                {
                    chemicals.Add(chemicalsToAdd[j]);
                }
            }

            foreach (string chem in chemicals)
            {
                Console.Write($"{chem} ");
            }
            Console.WriteLine();
        }
    }
}
