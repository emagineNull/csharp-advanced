using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var cupsQueue = new Queue<int>(cupsCapacity);
            var bottlesStack = new Stack<int>(filledBottles);

            var wasted = 0;

            while (true)
            {
                if (!cupsQueue.Any())
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");
                    Console.WriteLine($"Wasted litters of water: {Math.Abs(wasted)}");
                    return;
                }
                if (!bottlesStack.Any())
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
                    Console.WriteLine($"Wasted litters of water: {Math.Abs(wasted)}");
                    return;
                }

                var currentCup = cupsQueue.Peek();
                var currentBottle = bottlesStack.Peek();

                if (currentCup > currentBottle)
                {
                    cupsQueue.Dequeue();
                    while (true)
                    {
                        currentCup -= currentBottle;

                        if (currentCup <= 0)
                        {
                            wasted += currentCup;
                            bottlesStack.Pop();
                            break;
                        }

                        bottlesStack.Pop();
                        currentBottle = bottlesStack.Peek();
                    }
                }
                else if (currentCup <= currentBottle)
                {
                    wasted += (currentCup - currentBottle);
                    cupsQueue.Dequeue();
                    bottlesStack.Pop();
                }
            }
        }
    }
}
