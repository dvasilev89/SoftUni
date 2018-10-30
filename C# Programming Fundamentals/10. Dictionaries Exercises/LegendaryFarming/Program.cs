using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

        keyMaterials.Add("shards", 0);
        keyMaterials.Add("motes", 0);
        keyMaterials.Add("fragments", 0);

        while (true)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split().ToArray();

            for (int i = 0; i < tokens.Length - 1; i+=2)
            {
                string material = tokens[i + 1].ToLower();
                int quantity = int.Parse(tokens[i]);

                if (keyMaterials.ContainsKey(material))
                {
                    keyMaterials[material] += quantity;
                }
                else
                {
                    if (junkMaterials.ContainsKey(material) == false)
                    {
                        junkMaterials.Add(material, 0);
                    }

                    junkMaterials[material] += quantity;
                }

                if (keyMaterials["shards"] >= 250)
                {                    
                    break;
                }
                else if (keyMaterials["fragments"] >= 250)
                {                    
                    break;
                }
                else if (keyMaterials["motes"] >= 250)
                {                    
                    break;
                }
            }

            if (keyMaterials["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyMaterials["shards"] = keyMaterials["shards"] - 250;
                break;
            }
            else if (keyMaterials["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyMaterials["fragments"] = keyMaterials["fragments"] - 250;
                break;
            }
            else if (keyMaterials["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                keyMaterials["motes"] = keyMaterials["motes"] - 250;
                break;
            }
        }

        foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }

        foreach (var junk in junkMaterials.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{junk.Key}: {junk.Value}");
        }
    }
}