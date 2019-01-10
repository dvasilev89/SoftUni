using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            List<IId> all = new List<IId>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                if (tokens.Length == 3)
                {
                    all.Add(new Citizens(tokens[2], tokens[0], tokens[1]));
                }
                else if (tokens.Length == 2)
                {
                    all.Add(new Robots(tokens[1], tokens[0]));
                }
            }

            var lastDigits = Console.ReadLine();

            all.Where(c => c.Id.EndsWith(lastDigits))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
