using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        List<int> sands = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string input = Console.ReadLine();

            int value = 0;
            int replacement = 0;

            if (input == "Mort")
            {
                break;
            }

            string[] line = input.Trim().Split().ToArray();

            string command = line[0];

            if (command == "Add")
            {
                value = int.Parse(line[1]);
                sands.Add(value);
                continue;
            }
            else if (command == "Remove")
            {
                value = int.Parse(line[1]);

                if (sands.Contains(value))
                {
                    sands.Remove(value);
                    continue;
                }
                else
                {
                    if (value >= 0 & value < sands.Count)
                    {
                        sands.RemoveAt(value);
                        continue;
                    }
                }
            }
            else if (command == "Replace")
            {
                value = int.Parse(line[1]);
                replacement = int.Parse(line[2]);

                if (sands.Contains(value))
                {
                    int replaceIndex = sands.IndexOf(value);
                    sands.Remove(value);
                    sands.Insert(replaceIndex, replacement);
                    continue;
                }
                else
                {
                    continue;
                }
            }
            else if (command == "Increase")
            {
                value = int.Parse(line[1]);
                int increasingValue = 0;
                int counter = 0;

                for (int i = 0; i < sands.Count; i++)
                {
                    if (sands[i] >= value)
                    {
                        increasingValue = sands[i];
                        counter++;
                        break;
                    }
                }

                if (counter == 1)
                {
                    for (int i = 0; i < sands.Count; i++)
                    {
                        sands[i] += increasingValue;
                    }
                }
                else if (counter == 0)
                {
                    increasingValue = sands[sands.Count - 1];

                    for (int i = 0; i < sands.Count; i++)
                    {
                        sands[i] += increasingValue;
                    }
                }



            }
            else if (command == "Collapse")
            {
                value = int.Parse(line[1]);

                for (int i = sands.Count - 1; i >= 0; i--)
                {
                    if (sands[i] < value)
                    {
                        sands.RemoveAt(i);
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", sands));
    }
}

