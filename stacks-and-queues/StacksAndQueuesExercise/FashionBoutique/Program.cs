using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(box);

            var racks = 0;
            var currentSum = 0;

            while (stack.Any())
            {
                var currentCloth = stack.Peek();

                if (currentSum + currentCloth <= rackCapacity)
                {
                    currentSum += stack.Pop();
                }
                else
                {
                    currentSum = 0;
                    racks++;
                }
            }

            if (currentSum > 0)
            {
                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
