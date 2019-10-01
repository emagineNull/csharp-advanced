using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            var n = commands[0];
            var s = commands[1];
            var x = commands[2];

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(integers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
            }
        }
    }
}
