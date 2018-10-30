using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        List<string> input = Console.ReadLine()
            .Split(", ; : . ! ( ) \" ' \\ / [ ] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();        

        List<string> lowerCase = new List<string>();
        List<string> mixedCase = new List<string>();
        List<string> upperCase = new List<string>();

        foreach (string word in input)
        {
            if (IsSpecial(word))
            {
                mixedCase.Add(word);
            }            
            else if (IsLower(word))
            {
                lowerCase.Add(word);
            }
            else if (IsUpper(word))
            {
                upperCase.Add(word);
            }
            else
            {
                mixedCase.Add(word);
            }
        }

        Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
    }

    static bool IsLower(string word)
    {
        return word == word.ToLower();
    }

    static bool IsUpper(string word)
    {
        return word == word.ToUpper();
    }

    static bool IsSpecial(string word)
    {
        if (word.IndexOfAny("1234567890;:><,.\\\"'*&#".ToCharArray()) == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

