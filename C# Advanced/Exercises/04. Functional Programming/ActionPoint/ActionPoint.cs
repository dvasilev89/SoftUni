using System;
using System.Linq;

namespace ActionPoint
{
    class ActionPoint
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            Print(names);
            
        }

        static Action<string[]> Print = names =>
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        };
    }
}
