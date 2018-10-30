﻿using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string regex = @"\+359([ |-])2(\1)\d{3}(\1)\d{4}\b";

        string phones = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(phones, regex);

        string[] matchedPhones = phoneMatches
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}