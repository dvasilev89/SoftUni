using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int k = input.Length / 4;

        List<int> leftSide = input.Take(k).Reverse().ToList();
        List<int> downRow = input.Skip(k).Take(k * 2).ToList();
        List<int> rightSide = input.Skip(k + k *2).Take(k).Reverse().ToList();

        List<int> topRow = leftSide.Concat(rightSide).ToList();

        int[] result = new int[2 * k];

        int sum = 0;

        for (int i = 0; i < k * 2; i++)
        {
            sum = topRow[i] + downRow[i];
            result[i] = sum;
        }

        Console.WriteLine(string.Join(" ", result));        
    }
}

