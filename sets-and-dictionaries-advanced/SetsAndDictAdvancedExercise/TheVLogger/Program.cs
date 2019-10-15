using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Statistics")
                {
                    break;
                }

                string[] commandParts = command.Split();

                string vlogger = commandParts[0];

                if (commandParts.Length == 4 && !vloggers.ContainsKey(vlogger))
                {
                    vloggers.Add(vlogger, new Dictionary<string, HashSet<string>>());
                    vloggers[vlogger].Add("followers", new HashSet<string>());
                    vloggers[vlogger].Add("following", new HashSet<string>());
                }

                if (commandParts.Length == 3)
                {
                    string member = commandParts[2];

                    if (vlogger != member && vloggers.ContainsKey(vlogger) && vloggers.ContainsKey(member))
                    {
                        vloggers[vlogger]["following"].Add(member);
                        vloggers[member]["followers"].Add(vlogger);
                    }
                }
            }

            int counter = 1;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : " +
                    $"{vlogger.Value["followers"].Count} followers, " +
                    $"{vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }
        }
    }
}
