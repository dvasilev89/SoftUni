using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine()
            .Split("|")
            //.Reverse()           
            .ToList();

        List<string> numbers = new List<string>();
       

        for (int i = 0; i < input.Count / 2; i++)
        {
            string temp = input[i];
            input[i] = input[input.Count - 1 - i];
            input[input.Count - 1 - i] = temp;
        }

        for (int i = 0; i < input.Count; i++)
        {
            string text = input[i];
            string[] splitted = text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            string merged = string.Join(" ", splitted);
            numbers.Add(merged);
        }        

        Console.WriteLine(string.Join(" ", numbers));        
    }
}

