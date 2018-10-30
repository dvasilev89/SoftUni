using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> townTime = new Dictionary<string, int>();
        Dictionary<string, int> townCount = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Slide rule")
            {
                break;
            }

            string regex = @"(?<town>.+):(?<time>.+)->(?<count>.+)";

            Match match = Regex.Match(input, regex);

            var town = match.Groups["town"].Value;
            string timeOrAmbush = match.Groups["time"].Value;
            int count = int.Parse(match.Groups["count"].Value);
            int time = 0;

            bool IsTime = int.TryParse(timeOrAmbush, out time);

            if (IsTime)
            {
                if (townTime.ContainsKey(town) == false)
                {
                    townTime.Add(town, 0);
                    townCount.Add(town, 0);
                }

                townTime[town] = time;

                if (time < townTime[town])
                {
                    townTime[town] = time;
                }

                townCount[town] += count;
            }            
        }

        foreach (var town in townTime)
        {
            foreach (var town2 in townCount)
            {
                Console.WriteLine("{0} -> Time: {1} -> Passengers: {2}", town.Key, town.Value, town2.Value);
            }
        }

    }
}

