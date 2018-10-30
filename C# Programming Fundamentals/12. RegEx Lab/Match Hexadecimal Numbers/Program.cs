using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string regex = @"(0x|[0-9A-F])?[0-9A-F]+\b";

        string numbersString = Console.ReadLine();

        MatchCollection numbers = Regex.Matches(numbersString, regex);

        string[] matchedPhones = numbers
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(" ", matchedPhones));
    }
}