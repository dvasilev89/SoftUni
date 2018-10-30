using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split()
                    .Select(x => int.Parse(x))
                    .ToArray();

        int k = arr.Length / 4;

        int[] left = new int[k];
        int[] middle = new int[k * 2];
        int[] right = new int[k];

        int[] sum = new int[k * 2];

        for (int i = 0; i < k; i++)
        {
            left[i] = arr[k - 1 - i];
        }

        for (int i = 0; i < k; i++)
        {
            right[i] = arr[arr.Length - 1 - i];
        }

        for (int i = 0; i < 2 * k; i++)
        {
            middle[i] = arr[k + i];
        }

        for (int i = 0; i < k; i++)
        {
            sum[i] = left[i] + middle[i];
            sum[sum.Length - 1 - i] = middle[middle.Length - 1 - i] + right[right.Length - 1 - i];
        }
        
        Console.WriteLine(string.Join(" ", sum));
    }
}

