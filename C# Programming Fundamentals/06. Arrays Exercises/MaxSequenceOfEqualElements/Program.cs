using System;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {

        int[] sequence = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();


        int len = 1;
        int bestStart = 0;
        int bestLength = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                len++;
                if (len > bestLength)
                {
                    bestLength = len;
                    bestStart = sequence[i];
                }
            }
            else
            {
                len = 1;
            }
        }

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(bestStart + " ");
        }

        Console.WriteLine();
    }
}
