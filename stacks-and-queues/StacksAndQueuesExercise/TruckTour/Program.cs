using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var pumpsCount = int.Parse(Console.ReadLine());

            var k = 0;
            var sum = 0;
            var m = 0;

            var pumpsInfo = new int[2 * pumpsCount];

            for (int i = 0; i < pumpsCount; i++)
            {
                int[] pumpInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                pumpsInfo[i] = pumpInfo[0];
                pumpsInfo[i + pumpsCount] = pumpInfo[1];
            }

            Queue<int> pumps = new Queue<int>();
            pumps.Enqueue(0);

            m++;

            var amountOfGas = pumpsInfo[0];
            var distanceToNext = pumpsInfo[pumpsCount];
            sum = amountOfGas - distanceToNext;

            for (int i = 1; i <= pumpsCount + k; i++)
            {
                if (sum < 0)
                {
                    pumps.Clear();
                    k += m;
                    m = 0;
                    pumps.Enqueue(i);
                    amountOfGas = pumpsInfo[i % pumpsCount];
                    distanceToNext = pumpsInfo[i % pumpsCount + pumpsCount];
                    sum = amountOfGas - distanceToNext;
                }
                else
                {
                    m++;
                    pumps.Enqueue(i);
                    amountOfGas = pumpsInfo[i % pumpsCount];
                    distanceToNext = pumpsInfo[i % pumpsCount + pumpsCount];
                    sum += amountOfGas - distanceToNext;
                }
            }
            Console.WriteLine(pumps.Peek());
        }
    }
}
