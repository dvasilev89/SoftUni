using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        char[] arr1 = Console.ReadLine().Split()
            .Select(x => char.Parse(x))
            .ToArray();

        char[] arr2 = Console.ReadLine().Split()
            .Select(x => char.Parse(x))
            .ToArray();

        if (arr1[0] <= arr2[0] && arr1.Length <= arr2.Length)
        {
            Console.WriteLine(string.Join("", arr1));
            Console.WriteLine(string.Join("", arr2));
        }
        else
        {
            Console.WriteLine(string.Join("", arr2));
            Console.WriteLine(string.Join("", arr1));
        }
    }
}