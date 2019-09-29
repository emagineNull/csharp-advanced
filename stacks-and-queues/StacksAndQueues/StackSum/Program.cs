using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split();

                if (tokens[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (tokens[0].ToLower() == "remove")
                {
                    if (stack.Count < int.Parse(tokens[1]))
                    {
                        continue;
                    }

                    for (int i = 0; i < int.Parse(tokens[1]); i++)
                    {
                        stack.Pop();
                    }
                }

                commandInfo = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
