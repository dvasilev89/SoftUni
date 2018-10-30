using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> lettars = new SortedDictionary<char, int>();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                char lettar = input[i];

                if (lettars.ContainsKey(lettar) == false)
                {
                    lettars.Add(lettar, 0);
                }

                lettars[lettar]++;
            }

            foreach (var character in lettars)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
