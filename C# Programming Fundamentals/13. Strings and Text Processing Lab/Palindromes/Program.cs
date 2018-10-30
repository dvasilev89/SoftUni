using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] words = input.Split(".,!? "
            .ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        List<string> palindroms = new List<string>();
        foreach (var word in words)
        {
            bool isPalindrome = IsPalindrome(word);

            if (isPalindrome)
            {
                palindroms.Add(word);
            }
        }

        palindroms = palindroms.Distinct().OrderBy(x => x).ToList();

        Console.WriteLine(string.Join(", ", palindroms));
        
    }

    static bool IsPalindrome(string word)
    {
        string reversed = new string(word.Reverse().ToArray());

        return String.Equals(reversed, word);        
    }
}

