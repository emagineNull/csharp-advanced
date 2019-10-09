using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var valueOfIntelligence = int.Parse(Console.ReadLine());

            var bulletsStack = new Stack<int>(bullets);
            var locksQueue = new Queue<int>(locks);

            var profit = valueOfIntelligence;
            var counter = 0;

            while (true)
            {
                if (bulletsStack.Any() && locksQueue.Any())
                {
                    var currentBullet = bulletsStack.Pop();
                    var currentLock = locksQueue.Peek();

                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        locksQueue.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }

                    counter++;
                    profit -= bulletPrice;
                }else if (!locksQueue.Any())
                {
                    Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${profit}");
                    return;
                }
                else if (!bulletsStack.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
                    return;
                }

                if (counter == gunBarrelSize && bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }
        }
    }
}
