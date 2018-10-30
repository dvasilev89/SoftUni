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

        int indexNum = -1;
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < i; k++)
            {
                leftSum += arr[k];
            }

            for (int j = i + 1; j < arr.Length; j++)
            {
                rightSum += arr[j];
            }

            if (leftSum == rightSum)
            {
                indexNum = i;
                Console.WriteLine(indexNum);
                break;
            }

            leftSum = 0;
            rightSum = 0;
        }

        if (indexNum == -1)
        {
            Console.WriteLine("no");
        }
    }
}