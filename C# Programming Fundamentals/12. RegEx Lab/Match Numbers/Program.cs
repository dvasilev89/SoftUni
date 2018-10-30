using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

        string datesStrings = Console.ReadLine();

        MatchCollection dates = Regex.Matches(datesStrings, regex);

        string[] matchedPhones = dates
            .Cast<Match>()
            .Select(a => a.Value.Trim())            
            .ToArray();

        Console.WriteLine(string.Join(" ", matchedPhones));
    }
}