using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLength = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int firstSetLength = setsLength[0];
            int secondSetLength = setsLength[1];

            for (int i = 0; i < firstSetLength; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                firstSet.Add(currentNum);
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                secondSet.Add(currentNum);
            }

            HashSet<int> repeatingElements = new HashSet<int>();

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    repeatingElements.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", repeatingElements));
        }
    }
}
