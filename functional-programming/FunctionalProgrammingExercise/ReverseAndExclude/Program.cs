using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisable = x => x % n == 0;

            Array.Reverse(input);

            Func<int[], int[]> excl = x => x.Where(y => !isDivisable(y)).ToArray();

            input = excl(input);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
