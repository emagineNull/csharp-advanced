using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var queue = new Queue<string>(input);
            var served = new Stack<string>();

            var command = Console.ReadLine().Split('-');

            while (command[0] != "End")
            {
                if (command[0] == "Service")
                {
                    var currentCar = queue.Dequeue();
                    served.Push(currentCar);
                    Console.WriteLine($"Vehicle {currentCar} got served.");
                }
                else if (command[0] == "CarInfo")
                {
                    if (queue.Contains(command[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command[0] == "History")
                {
                    Console.WriteLine($"{string.Join(", ", served)}");
                }

                command = Console.ReadLine().Split('-');
            }
            
            Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            Console.WriteLine($"Served vehicles: {string.Join(", ", served)}");
        }
    }
}
