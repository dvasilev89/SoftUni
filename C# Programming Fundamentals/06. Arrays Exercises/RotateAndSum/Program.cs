using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split()
                      .Select(int.Parse)
                      .ToArray();  

        int rotations = int.Parse(Console.ReadLine());

        int[] sumArray =  new int [input.Length];

        for (int i = 0; i < rotations; i++)
        {
            Shift(input);
            SumArray(input, sumArray);
        }
               
        Console.WriteLine(string.Join(" ", sumArray));        
    }

    static void Shift(int[] input)
    {
        int last = input[input.Length - 1];

        for (int i = input.Length - 1; i > 0; i--)
        {
            input[i] = input[i - 1];
        }

        input[0] = last;
    }

    private static void SumArray(int[] input, int[] sumArray)
    {
        for (int i = 0; i < input.Length; i++)
        {
            sumArray[i] += input[i];
        }
    }

}

