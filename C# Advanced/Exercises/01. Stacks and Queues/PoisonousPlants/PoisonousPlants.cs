﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            List<int> indexes = new List<int>();

            int numberOfPlants = int.Parse(Console.ReadLine());

            List<int> plants = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();            

            int days = 0;

            while (true)
            {
                for (int i = 0; i < plants.Count - 1; i++)
                {
                    if (plants[i] < plants[i + 1])
                    {
                        indexes.Add(i + 1);
                    }
                }

                if (indexes.Count == 0)
                {
                    break;
                }                

                for (int i = indexes.Count - 1; i >= 0; i--)
                {
                    plants.RemoveAt(indexes[i]);                    
                }

                days++;
                indexes.Clear();
            }

            Console.WriteLine(days);
        }
    }
}
