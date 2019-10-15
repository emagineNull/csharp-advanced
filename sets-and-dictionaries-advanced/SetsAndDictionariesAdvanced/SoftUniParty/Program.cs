using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "PARTY")
                {
                    break;
                }

                guests.Add(command);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                guests.Remove(command);
            }

            Console.WriteLine($"{guests.Count}");

            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            foreach (var guest in guests)
            {
                char firstSymbol = guest[0];
                if (!char.IsDigit(firstSymbol))
                {
                    regularGuests.Add(guest);
                }
                else
                {
                    vipGuests.Add(guest);
                }
            }

            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }

            foreach (var reg in regularGuests)
            {
                Console.WriteLine(reg);
            }
        }
    }
}
