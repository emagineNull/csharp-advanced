using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            var n = commands[0];
            var s = commands[1];
            var x = commands[2];

            for (int i = 0; i < n; i++)
            {
                stack.Push(integers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
            }
        }
    }
}
