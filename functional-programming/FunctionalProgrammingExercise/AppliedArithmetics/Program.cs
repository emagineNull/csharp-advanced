using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Func<int[], int[]> adder = x => x.Select(y => y + 1).ToArray();
            Func<int[], int[]> multiplier = x => x.Select(y => y * 2).ToArray();
            Func<int[], int[]> subtracter = x => x.Select(y => y - 1).ToArray();
            Func<int[], string> printer = x => string.Join(" ", x);

            while (command != "end")
            {
                if (command == "add")
                {
                    input = adder(input);
                }
                else if (command == "multiply")
                {
                    input = multiplier(input);
                }
                else if (command == "subtract")
                {
                    input = subtracter(input);
                }
                else if (command == "print")
                {
                    Console.WriteLine(printer(input));
                }

                command = Console.ReadLine();
            }
        }
    }
}
