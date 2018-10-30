using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int numberOfColours = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfColours; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " ", "->", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string colour = input[0];

                if (wardrobe.ContainsKey(colour) == false)
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    if (wardrobe[colour].ContainsKey(input[j]) == false)
                    {
                        wardrobe[colour].Add(input[j], 1);
                    }
                    else
                    {
                        wardrobe[colour][input[j]]++;
                    }
                }                
            }

            string[] findCloth = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string colourToFind = findCloth[0];
            string clothToFind = findCloth[1];

            foreach (var coloursInWardrobe in wardrobe)
            {
                Console.WriteLine($"{coloursInWardrobe.Key} clothes:");

                Dictionary<string, int> clothes = coloursInWardrobe.Value;

                foreach (var cloth in clothes)
                {
                    if (colourToFind == coloursInWardrobe.Key && clothToFind == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
