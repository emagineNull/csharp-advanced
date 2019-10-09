using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLightSeconds = int.Parse(Console.ReadLine());
            var secondsPassCrossroad = int.Parse(Console.ReadLine());

            var carsQueue = new Queue<string>();

            var counter = 0;

            while (true)
            {
                var car = Console.ReadLine();

                var greenLights = greenLightSeconds;
                var passSeconds = secondsPassCrossroad;

                if (car == "END")
                {
                    Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                        $"{counter} total cars passed the crossroads.");
                    return;
                }

                if (car == "green")
                {
                    while (greenLights > 0 && carsQueue.Count != 0)
                    {

                        var firstInQueue = carsQueue.Dequeue();
                        greenLights -= firstInQueue.Count();
                        if (greenLights >= 0)
                        {
                            counter++;
                        }

                        else
                        {
                            passSeconds += greenLights;
                            if (passSeconds < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{firstInQueue} was hit at" +
                                    $" {firstInQueue[firstInQueue.Length + passSeconds]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(car);
                }
            }
        }
    }
}
