using System;
using System.Linq;

namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int predicateLength = int.Parse(Console.ReadLine());

            Predicate<string> predicate = p => p.Length <= predicateLength;

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var name in names)
            {
                if (predicate(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
