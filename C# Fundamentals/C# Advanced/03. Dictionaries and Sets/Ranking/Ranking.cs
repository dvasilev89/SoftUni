using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> submissions = new SortedDictionary<string, Dictionary<string, int>>();            

            while (true)
            {
                string firstInput = Console.ReadLine();

                if (firstInput == "end of contests")
                {
                    break;
                }

                string[] contestsInfo = firstInput
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string contest = contestsInfo[0];
                string passwordForContest = contestsInfo[1];

                if (contests.ContainsKey(contest) == false)
                {
                    contests.Add(contest, passwordForContest);
                }
            }

            while (true)
            {
                string secondInput = Console.ReadLine();

                if (secondInput == "end of submissions")
                {
                    break;
                }

                string[] submissionInfo = secondInput
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string submission = submissionInfo[0];
                string submissionPassword = submissionInfo[1];
                string userName = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);

                bool isValid = contests.ContainsKey(submission);

                if (isValid)
                {
                    bool isPassValid = (contests[submission] == submissionPassword);

                    if (isPassValid)
                    {
                        if (submissions.ContainsKey(userName) == false)
                        {
                            submissions.Add(userName, new Dictionary<string, int>());
                        }

                        if (submissions[userName].ContainsKey(submission) == false)
                        {
                            submissions[userName].Add(submission, points);
                        }

                        if (submissions[userName][submission] < points)
                        {
                            submissions[userName][submission] = points;
                        }

                    }
                }
            }

            int bestPoints = 0;
            string bestUser = "";

            foreach (var user in submissions)
            {
                int totalPoints = 0;

                foreach (var sub in user.Value)
                {
                    totalPoints += sub.Value;
                }

                if (totalPoints > bestPoints)
                {
                    bestPoints = totalPoints;
                    bestUser = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in submissions)
            {
                Console.WriteLine($"{user.Key}");

                foreach (var sub in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {sub.Key} -> {sub.Value}");
                }
            }
        }
    }
}
