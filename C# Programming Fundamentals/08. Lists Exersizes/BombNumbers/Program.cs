using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] bomb = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToArray();

        bool isBomb = true;

        while (isBomb)
        {
            int bombIndex = input.IndexOf(bomb[0]);

            if (bombIndex + bomb[1] > input.Count)
            {
                input.RemoveRange(bombIndex - bomb[1], input.Count - (bombIndex - bomb[1]));
            }
            else if (bombIndex - bomb[1] < 0)
            {
                input.RemoveRange(0, bombIndex + bomb[1] + 1);
            }
            else
            {
                input.RemoveRange(bombIndex - bomb[1], bomb[1] * 2 + 1);
            }

            isBomb = input.Exists(x => x == bomb[0]);
        }
        Console.WriteLine(input.Sum());       
    }
}

