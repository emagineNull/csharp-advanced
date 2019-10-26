using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine()
                .Split()
                .ToList();
            


            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandParts = command
                    .Split();

                string action = commandParts[0];

                if (action == "Double")
                {

                }
            }
        }
    }
}
