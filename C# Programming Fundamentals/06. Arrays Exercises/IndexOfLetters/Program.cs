using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[26];

        string input = Console.ReadLine();
        
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('a' + i);            
        }

        for (int i = 0; i < input.Length; i++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (input[i] == alphabet[k])
                {
                    Console.WriteLine($"{input[i]} -> {k}");
                }
            }
        }        
    }
}

