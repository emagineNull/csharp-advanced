using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            var stack = new Stack<string>();

            var currentParantheses = input[0].ToString();

            for (int i = 1; i < input.Length; i++)
            {

                if (currentParantheses == "(")
                {
                    stack.Push(currentParantheses);
                }
                else if (currentParantheses == "{")
                {
                    stack.Push(currentParantheses);
                }
                else if (currentParantheses == "[")
                {
                    stack.Push(currentParantheses);
                }
                else if (currentParantheses == ")" && stack.Peek() == "(")
                {
                    stack.Pop();
                }
                else if (currentParantheses == "}" && stack.Peek() == "{")
                {
                    stack.Pop();
                }
                else if (currentParantheses == "]" && stack.Peek() == "[")
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                
                currentParantheses = input[i].ToString();
            }

            Console.WriteLine("YES");
        }
    }
}
