using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var stack = new Stack<string>(4);

            while (command != "END")
            {
                string[] commandParts = command.Split();

                string action = commandParts[0];

                if (action == "Push")
                {
                    string[] elemsToPush = string.Join("", commandParts.Skip(1)).Split(',');

                    for (int i = 0; i < elemsToPush.Length; i++)
                    {
                        stack.Push(elemsToPush[i]);
                    }
                }
                else if (action == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                command = Console.ReadLine();
            }

            Printer(stack);
        }

        public static void Printer(Stack<string> collection)
        {
            foreach (var num in collection)
            {
                if (num != null)
                {
                    Console.WriteLine(num);
                }
            }

            foreach (var num in collection)
            {
                if (num != null)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
