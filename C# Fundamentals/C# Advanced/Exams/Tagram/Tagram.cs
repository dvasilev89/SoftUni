using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam2Tagram
{
    class Tagram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> records = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalLikes = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] recordInfo = input.Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string username = recordInfo[0];

                if (username == "ban" == false)
                {
                    string tag = recordInfo[1];
                    int likes = int.Parse(recordInfo[2]);

                    if (records.ContainsKey(username) == false)
                    {
                        records.Add(username, new Dictionary<string, int>());
                        totalLikes.Add(username, 0);
                    }

                    if (records[username].ContainsKey(tag) == false)
                    {
                        records[username].Add(tag, 0);
                    }

                    records[username][tag] += likes;
                    totalLikes[username] += likes;
                }
                else if (username == "ban")
                {
                    string banName = recordInfo[1];

                    if (records.ContainsKey(banName))
                    {
                        records.Remove(banName);
                    }
                }
            }

            

            foreach (var username in records.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
            {
                Console.WriteLine($"{username.Key}");

                foreach (var tag in username.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }

        }
    }

}






