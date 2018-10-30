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

        bool isEvenOrOdd = false;

        while (!isEvenOrOdd)
        {
            comands = Console.ReadLine().Split().ToList();
            
            if (comands[0] == "Delete")
            {
                numbers.RemoveAll(x => x == int.Parse(comands[1]));
                comands.Clear();
            }
            else if (comands[0] == "Insert")
            {
                numbers.Insert(int.Parse(comands[2]), int.Parse(comands[1]));
                comands.Clear();
            }
            else if (comands[0] == "Even")
            {
                numbers.RemoveAll(x => x % 2 != 0);
                isEvenOrOdd = true;
            }
            else if (comands[0] == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
                isEvenOrOdd = true;
            }
        }        

        Console.WriteLine(string.Join(" ", numbers));
        
    }
}

