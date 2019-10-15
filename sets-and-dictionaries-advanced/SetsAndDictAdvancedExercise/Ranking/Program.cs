using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsAndPasswords = new Dictionary<string, string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of contests")
                {
                    break;
                }

                string[] commandParts = command.Split(':');

                string contest = commandParts[0];
                string password = commandParts[1];

                contestsAndPasswords.Add(contest, password);
            }

            var candidates = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of submissions")
                {
                    break;
                }

                string[] commandParts = command.Split("=>");

                string contest = commandParts[0];
                string password = commandParts[1];
                string candidate = commandParts[2];
                int score = int.Parse(commandParts[3]);

                if (!contestsAndPasswords.ContainsKey(contest))
                {
                    continue;
                }

                if (contestsAndPasswords[contest] != password)
                {
                    continue;
                }

                if (!candidates.ContainsKey(candidate))
                {
                    candidates.Add(candidate, new Dictionary<string, int>());
                }

                if (!candidates[candidate].ContainsKey(contest))
                {
                    candidates[candidate].Add(contest, 0);
                }

                if (candidates[candidate][contest] < score)
                {
                    candidates[candidate][contest] = score;
                }
            }

            string bestCandidate = string.Empty;
            int maxPoints = 0;

            foreach (var candidate in candidates)
            {
                int currentSum = 0;
                foreach (var candidateAndScore in candidate.Value)
                {
                    currentSum += candidateAndScore.Value;
                }

                if (currentSum > maxPoints)
                {
                    bestCandidate = candidate.Key;
                    maxPoints = currentSum;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var candidate in candidates.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{candidate.Key}");
                foreach (var kvp in candidate.Value.OrderByDescending(p => p.Value))
                {
                    string contestName = kvp.Key;
                    int points = kvp.Value;

                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}
