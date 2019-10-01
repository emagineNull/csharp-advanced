using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var query = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var command = query[0];

                if (command == 1)
                {
                    stack.Push(query[1]);
                }
                else if (command == 2 && stack.Any())
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Any())
                {
                    Console.WriteLine($"{stack.Max()}");
                }
                else if (command == 4 && stack.Any())
                {
                    Console.WriteLine($"{stack.Min()}");
                }
            }

            if (stack.Any())
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
