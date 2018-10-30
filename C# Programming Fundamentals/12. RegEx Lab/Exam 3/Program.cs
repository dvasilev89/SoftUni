using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split('|').ToArray();

        string firstPart = input[0];
        string secondPart = input[1];
        string thitdPart = input[2];

        Console.WriteLine(firstPart);
        Console.WriteLine(secondPart);
        Console.WriteLine(thitdPart);

        string firstPattern = @"([#$%*&])(?<capitals>[A-Z]+)+\1";

        MatchCollection capitalLetters = Regex.Matches(firstPart, firstPattern);        

        string[] validLetters = capitalLetters
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        string secondPattern = @"(?<asciiCode>[0-9]{2}):(?<length>[0][0-9])";

        MatchCollection asciiLength = Regex.Matches(secondPart, secondPattern);

        string[] validAsciiLength = asciiLength
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        string thirdPattern = @"\b[A-Z][a-z]+";

        MatchCollection words = Regex.Matches(thitdPart, thirdPattern);

        string[] validWords = words
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", validLetters));
        Console.WriteLine(string.Join(", ", validAsciiLength));
        Console.WriteLine(string.Join(", ", validWords));
        
    }
}

