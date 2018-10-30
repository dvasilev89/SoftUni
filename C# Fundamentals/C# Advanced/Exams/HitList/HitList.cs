using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4HitList
{
    class HitList
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, string>> hitList = new Dictionary<string, SortedDictionary<string, string>>();

            int targetInfoIndex = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end transmissions")
                {
                    break;
                }

                string[] info = input.Split(new char[] { '=', ':', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = info[0];

                if (hitList.ContainsKey(name) == false)
                {
                    hitList.Add(name, new SortedDictionary<string, string>());
                }

                if (info.Length == 3)
                {
                    string key = info[1];
                    string value = info[2];

                    if (hitList[name].ContainsKey(key) == false)
                    {
                        hitList[name].Add(key, value);
                    }

                    hitList[name][key] = value;
                }
                else
                {
                    for (int i = 0; i < info.Length - 1; i += 2)
                    {
                        string key = info[i + 1];
                        string value = info[i + 2];

                        if (hitList[name].ContainsKey(key) == false)
                        {
                            hitList[name].Add(key, value);
                        }

                        hitList[name][key] = value;
                    }
                }

            }

            string[] kill = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string whoToKill = kill[1];

            int infoIndex = 0;

            foreach (var name in hitList)
            {
                if (whoToKill == name.Key)
                {
                    Console.WriteLine($"Info on {name.Key}:");

                    foreach (var value in name.Value)
                    {
                        Console.WriteLine($"---{value.Key}: {value.Value}");
                        infoIndex += (value.Key.Length + value.Value.Length);
                    }
                }
            }

            Console.WriteLine($"Info index: {infoIndex}");

            if (targetInfoIndex <= infoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                int result = targetInfoIndex - infoIndex;
                Console.WriteLine($"Need {result} more info.");
            }
        }
    }
}
