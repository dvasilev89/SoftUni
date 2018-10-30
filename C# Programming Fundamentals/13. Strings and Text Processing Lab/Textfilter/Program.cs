using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string input = Console.ReadLine();

        foreach (string word in bannedWords)
        {
            input = input.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(input);
    }
}

