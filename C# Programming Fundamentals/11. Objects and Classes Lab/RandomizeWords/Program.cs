using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split().ToArray();

        Random rdm = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int randomPosition = rdm.Next(0, words.Length);
            string currentWord = words[i];
            words[i] = words[randomPosition];
            words[randomPosition] = currentWord;
        }

        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}

