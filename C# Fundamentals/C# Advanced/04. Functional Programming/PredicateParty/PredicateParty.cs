using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate;
            Action<List<string>> Print = names => Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            List<string> guests = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] commandsArgs = Console.ReadLine().Split();

                string command = commandsArgs[0];
                string predicateName = commandsArgs[1];
                string value = commandsArgs[2];

                predicate = GetPredicate(predicateName, value);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else
                {
                    var newGuest = guests.FindAll(predicate);

                    foreach (var guest in newGuest)
                    {
                        int indexOfCurrentGuest = guests.IndexOf(guest);

                        guests.Insert(indexOfCurrentGuest + 1, guest);
                    }
                }           

                input = Console.ReadLine();
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Print(guests);
            }
        }

        private static Predicate<string> GetPredicate(string predicateName, string value)
        {
            if (predicateName == "StartsWith")
            {
                return p => p.StartsWith(value);
            }
            else if (predicateName == "EndsWith")
            {
                return p => p.EndsWith(value);
            }
            else if (predicateName == "Length")
            {
                return p => p.Length == int.Parse(value);
            }

            return null;
        }
    }
}
