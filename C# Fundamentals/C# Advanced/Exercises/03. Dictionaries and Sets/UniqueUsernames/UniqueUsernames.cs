using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (string person in names)
            {
                Console.WriteLine(person);
            }
        }
    }
}
