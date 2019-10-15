using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (!dict.ContainsKey(currentSymbol))
                {
                    dict[currentSymbol] = 0;
                }

                dict[currentSymbol]++;
            }

            foreach (var kvp in dict)
            {
                char symbol = kvp.Key;
                int times = kvp.Value;

                Console.WriteLine($"{symbol}: {times} time/s");
            }
        }
    }
}
