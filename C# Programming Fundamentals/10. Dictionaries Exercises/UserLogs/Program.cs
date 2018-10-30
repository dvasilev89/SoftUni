using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, List<string>>> users = new Dictionary<string, Dictionary<string, List<string>>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] userData = input
                .Split(new string[] { "IP=", "message=", "user=", " " }
                .ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string userName = userData.Last();
            string userIp = userData.First();
            string message = userData[1];

            if (users.ContainsKey(userName) == false)
            {
                users.Add(userName, new Dictionary<string, List<string>>());
            }

            if (users[userName].ContainsKey(userIp) == false)
            {
                users[userName].Add(userIp, new List<string>());
            }

            users[userName][userIp].Add(message);
        }

        foreach (var user in users.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{user.Key}:");

            Dictionary<string, List<string>> ipAdresses = users[user.Key].ToDictionary(x => x.Key, x => x.Value);

            int count = 0;

            foreach (var ip in ipAdresses)
            {
                count++;
                if (count == ipAdresses.Keys.Count)
                {
                    Console.Write($"{ip.Key} => {ip.Value.Count}.");
                }
                else
                {
                    Console.Write($"{ip.Key} => {ip.Value.Count}, ");
                }               
            }
            Console.WriteLine();
        }
    }
}