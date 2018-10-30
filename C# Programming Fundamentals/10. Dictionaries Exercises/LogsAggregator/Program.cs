using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<string, List<string>> users = new SortedDictionary<string, List<string>>();
        SortedDictionary<string, int> totalDuration = new SortedDictionary<string, int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split().ToArray();

            string userIp = tokens.First();
            string userName = tokens[1];
            int duration = int.Parse(tokens.Last());

            if (users.ContainsKey(userName) == false)
            {
                users.Add(userName, new List<string>());
                totalDuration.Add(userName, 0);
            }

            users[userName].Add(userIp);
            totalDuration[userName] += duration;

            users[userName] = users[userName].Distinct().OrderBy(x => x).ToList();
        }        

        foreach (var user in totalDuration)
        {
            string currentUser = user.Key;
            Console.WriteLine($"{user.Key}: {user.Value} " + "[" + string.Join(", ", users[currentUser]) + "]");                    
        }
    }
}