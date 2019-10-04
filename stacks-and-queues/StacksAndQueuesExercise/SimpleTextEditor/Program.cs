using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var text = string.Empty;

            var previous = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    var argument = command[1];
                    previous.Push(text);

                    text += argument;
                }
                else if (command[0] == "2")
                {
                    var argument = int.Parse(command[1]);
                    previous.Push(text);

                    text = text.Substring(0, text.Length - argument);
                }
                else if (command[0] == "3")
                {
                    var argument = int.Parse(command[1]);

                    Console.WriteLine(text[argument - 1]);
                }
                else if (command[0] == "4")
                {
                    if (previous.Any())
                    {
                        text = previous.Pop();
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
            }
        }
    }
}
