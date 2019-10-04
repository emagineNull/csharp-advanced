using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLightDuration = int.Parse(Console.ReadLine());
            var freeWindowDuration = int.Parse(Console.ReadLine());

            var currentGreen = greenLightDuration;
            var currentFreeWindow = freeWindowDuration;

            var crash = ' ';

            var road = new Queue<string>();

            var totalCarsPassed = 0;
            var flag = false;

            var command = Console.ReadLine();

            while (command != "END")
            {
                if (command != "green")
                {
                    road.Enqueue(command);
                }
                else
                {
                    var currentCar = road.Peek();

                    while (true)
                    {
                        if (currentGreen - currentCar.Length >= 0)
                        {
                            currentGreen -= currentCar.Length;
                            road.Dequeue();
                            totalCarsPassed++;
                        }
                        else
                        {
                            break;
                        }

                        if (!road.Any())
                        {
                            currentCar = string.Empty;
                            break;
                        }

                        currentCar = road.Peek();
                    }
                    if (freeWindowDuration > 0 && currentCar != string.Empty)
                    {
                        if (currentFreeWindow - currentCar.Length >= 0)
                        {
                            currentFreeWindow -= currentCar.Length;
                            road.Dequeue();
                            totalCarsPassed++;
                        }
                        else
                        {
                            crash = currentCar[Math.Abs(currentFreeWindow + currentGreen)];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {crash}.");
                            return;
                        }
                    }
                }

                currentGreen = greenLightDuration;
                currentFreeWindow = freeWindowDuration;
                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
