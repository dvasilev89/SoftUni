using System;
using System.Linq;

namespace ActionPoint2
{
    class ActionPoint2
    {
        static void Main(string[] args)
        {
            Action<string> Print = name => Console.WriteLine(name);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(x => Print(x));
        }
    }
}
