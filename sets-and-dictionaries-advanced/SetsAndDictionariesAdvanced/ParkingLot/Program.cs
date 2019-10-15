using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandParts = command
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandParts[0];
                string carNumber = commandParts[1];

                if (action == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                if (action == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }
            }

            if (!carNumbers.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var carNum in carNumbers)
                {
                    Console.WriteLine(carNum);
                }
            }
        }
    }
}
