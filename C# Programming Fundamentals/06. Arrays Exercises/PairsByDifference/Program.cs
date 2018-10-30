using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int num = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) == num)
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}

