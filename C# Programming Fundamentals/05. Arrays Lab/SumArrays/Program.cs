using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = Console.ReadLine().Split()
            .Select((e => int.Parse(e)))
            .ToArray();

        int[] arr2 = Console.ReadLine().Split()
            .Select((e => int.Parse(e)))
            .ToArray();
        // Finished taking input
        string resultString = "";

        int[] newestArray;
        int[] biggestArray;

        if (arr1.Length > arr2.Length)
        {
            biggestArray = arr1;
            newestArray  = DuplicateArray(biggestArray.Length, arr2);
        }
        else if (arr1.Length < arr2.Length)
        {
            biggestArray = arr2;
            newestArray  = DuplicateArray(biggestArray.Length, arr1);
        }
        else
        {
            newestArray  = arr1;
            biggestArray = arr2;
        }
        //Summing and Printing
        for (int i = 0; i < biggestArray.Length; i++)
        {
            int sum = biggestArray[i] + newestArray[i];
            resultString += sum + " ";
        }
        Console.WriteLine(resultString.Trim());
    }

    private static int[] DuplicateArray(int n,int[] inpArr)
    {
        int[] arr = new int[n];
        int counter = 0;
        while (counter<n)
        {
            for (int i = 0; i < inpArr.Length; i++)
            {
                if (counter >= n)
                    break;
                arr[counter++] = inpArr[i];
                //Console.WriteLine(string.Join(" ", arr));
            }

        }
        return arr;
    }
}

