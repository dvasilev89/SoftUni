using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string[] arr1 = Console.ReadLine().Split();

        string[] arr2 = Console.ReadLine().Split();

        int counter = 0;

        if (arr1[0] == arr2[0])
        {
            int i = 0;
            while (arr1[i] == arr2[i])
            {
                counter++;
                i++;
            }
        }
        else
        {
            int i = arr1.Length - 1;
            int j = arr2.Length - 1;
            while (arr1[i] == arr2[j])
            {
                counter++;
                i--;
                j--;
            }
        }
        Console.WriteLine(counter);
    }
}

