using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => "Sir " + x)
                .ToArray();

            Action<string[]> printer = x => Array.ForEach(x, Console.WriteLine);

            printer(input);
        }
    }
}
