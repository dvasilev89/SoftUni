using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Trim()
            .Split()
            .Select(x => int.Parse(x))
            .ToList();

        List<string> comands = new List<string>();

        while (true)
        {
            comands = Console.ReadLine().Trim().Split().ToList();

            if (comands[0] == "add")
            {
                numbers.Insert(int.Parse(comands[1]), int.Parse(comands[2]));
                comands.Clear();
            }
            else if (comands[0] == "addMany")
            {
                for (int i = comands.Count - 1; i >= 2; i--)
                {
                    numbers.Insert(int.Parse(comands[1]), int.Parse(comands[i]));
                }
                comands.Clear();
            }
            else if (comands[0] == "contains")
            {
                bool isContaines = numbers.Contains(int.Parse(comands[1]));

                if (isContaines)
                {
                    Console.WriteLine(numbers.IndexOf(int.Parse(comands[1])));
                }
                else
                {
                    Console.WriteLine("-1");
                }
                comands.Clear();
            }
            else if (comands[0] == "remove")
            {
                numbers.RemoveAt(int.Parse(comands[1]));
                comands.Clear();
            }
            else if (comands[0] == "shift")
            {
                for (int i = 0; i < (int.Parse(comands[1])); i++)
                {
                    numbers.Add(numbers[i]);                    
                }

                for (int i = (int.Parse(comands[1])) - 1; i >= 0; i--)
                {
                    numbers.RemoveAt(i);
                }
                comands.Clear();
            }
            else if (comands[0] == "sumPairs")
            {
                for (int i = 0; i < numbers.Count - 1; i+=2)
                {
                    numbers[i] += numbers[i + 1];
                }

                if (numbers.Count % 2 == 0)
                {
                    for (int i = numbers.Count - 1; i >= 0; i -= 2)
                    {
                        numbers.RemoveAt(i);
                    }
                }
                else
                {
                    for (int i = numbers.Count - 2; i >= 0; i -= 2)
                    {
                        numbers.RemoveAt(i);
                    }
                }
                comands.Clear();
            }
            else if (comands[0] == "print")
            {
                break;
            }            
        }
        Console.WriteLine(new string('[', 1) + string.Join(", ", numbers) + new string(']', 1));
    }
}

