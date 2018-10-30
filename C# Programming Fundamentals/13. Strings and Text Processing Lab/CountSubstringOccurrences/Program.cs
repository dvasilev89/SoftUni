using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int count = 0;

        for (int i = 0; i <= input.Length - pattern.Length; i++)
        {
            char[] temp = input.Skip(i).Take(pattern.Length).ToArray();
            string subString = new string(temp);

            if (subString.Equals(pattern))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

