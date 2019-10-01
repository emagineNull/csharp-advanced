using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantity = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(orders);

            Console.WriteLine($"{queue.Max()}");

            while (true)
            {
                if (!queue.Any())
                {
                    Console.WriteLine("Orders complete");
                    return;
                }

                var currentOrder = queue.Peek();

                if (quantity - currentOrder >= 0)
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
            }
        }
    }
}
