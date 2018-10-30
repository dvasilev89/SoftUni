using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLenght = input[0];
            int secondSetLenght = input[1];

            for (int i = 0; i < firstSetLenght; i++)
            {
                int firstSetNumbers = int.Parse(Console.ReadLine());

                firstSet.Add(firstSetNumbers);
            }

            for (int i = 0; i < secondSetLenght; i++)
            {
                int secondSetNumbers = int.Parse(Console.ReadLine());

                secondSet.Add(secondSetNumbers);
            }

            foreach (int firstNum in firstSet)
            {
                foreach (int secondNum in secondSet)
                {
                    if (firstNum == secondNum)
                    {
                        Console.Write($"{firstNum} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
