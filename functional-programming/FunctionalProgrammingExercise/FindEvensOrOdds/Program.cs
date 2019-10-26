using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToList();

            var command = Console.ReadLine().ToLower();

            Predicate<int> isEven = n => n % 2 == 0;

            var numbers = GetNumbers(range, command, isEven);

            if (numbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static List<int> GetNumbers(List<int> range, string command, Predicate<int> isEven)
        {
            var numbers = new List<int>();
            var start = range[0];
            var end = range[1];

            for (int i = start; i <= end; i++)
            {
                if ((isEven(i) && command == "even") || (!isEven(i) && command == "odd"))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}
