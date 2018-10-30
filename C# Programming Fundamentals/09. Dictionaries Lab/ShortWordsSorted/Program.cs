using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine()
            .ToLower()
            .Split(". , : ; ( ) [ ] \" ' \\ / ! ? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        input.Sort();
        input = input.Distinct().ToList();

        input = input.Where(x => x.Length < 5).ToList();        
        
        Console.WriteLine(string.Join(", ", input));
    }
}

