using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class TheVLogger
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vLogger = 
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();          

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] vloggerInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstVlogger = vloggerInfo[0];
                string command = vloggerInfo[1];
                string secondVlogger = "";

                if (command == "joined")
                {
                    if (vLogger.ContainsKey(firstVlogger) == false)
                    {
                        vLogger.Add(firstVlogger, new Dictionary<string, SortedSet<string>>());

                        vLogger[firstVlogger].Add("followers", new SortedSet<string>());
                        vLogger[firstVlogger].Add("following", new SortedSet<string>());
                    }                    
                }
                else if (command == "followed")
                {
                    secondVlogger = vloggerInfo[2];

                    bool isValid = ((vLogger.ContainsKey(firstVlogger)) &&
                                   (vLogger.ContainsKey(secondVlogger)) && 
                                   (firstVlogger != secondVlogger));

                    if (isValid)
                    {
                        vLogger[firstVlogger]["following"].Add(secondVlogger);
                        vLogger[secondVlogger]["followers"].Add(firstVlogger);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vLogger.Keys.Count} vloggers in its logs.");

            int userNum = 0;

            foreach (var user in vLogger.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {           

                Console.WriteLine($"{++userNum}. {user.Key} : {user.Value["followers"].Count} followers, {user.Value["following"].Count} following");

                if (userNum == 1)
                {
                    foreach (var person in user.Value["followers"])
                    {
                        Console.WriteLine($"*  {person}");
                    }
                }
            }
        }
    }
}
