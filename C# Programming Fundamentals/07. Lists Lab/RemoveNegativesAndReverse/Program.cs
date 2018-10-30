using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();


        numbers.RemoveAll(x => x < 0);
        numbers.Reverse();
        
        //Console.WriteLine(string.Join(" ", numbers));


        //for (int i = 0; i < numbers.Count / 2; i++)
        //{
        //    int temp = numbers[i];
        //    numbers[i] = numbers[numbers.Count - 1 - i];
        //    numbers[numbers.Count - 1 - i] = temp;
        //}

        //for (int i = numbers.Count - 1; i >= 0; i--)
        //{
        //    if (numbers[i] < 0)
        //    {
        //        numbers.RemoveAt(i);                
        //    }
        //}

        if (numbers.Count > 0)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}

