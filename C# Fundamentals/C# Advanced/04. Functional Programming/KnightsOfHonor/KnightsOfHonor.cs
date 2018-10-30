using System;
using System.Linq;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Action<string> Print = name => Console.WriteLine(name);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => "Sir " + x)
                .ToList()
                .ForEach(Print);
        }
    }
}
