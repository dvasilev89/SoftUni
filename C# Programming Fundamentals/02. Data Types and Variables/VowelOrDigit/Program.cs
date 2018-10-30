using System;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();
        int number;
        bool digit = int.TryParse(input, out number);

        if (digit)
        {
            Console.WriteLine("digit");
        }
        else if (input == "a" || input == "e" || input == "o" || input == "u" || input == "i")
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

