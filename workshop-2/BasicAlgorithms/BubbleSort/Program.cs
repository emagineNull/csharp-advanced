using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new List<int> { 5, 10, 2, 1, 1, 10, 5, 2, 1, 1, 10 };

            for (int i = 0; i < coins.Count; i++)
            {
                for (int j = i + 1; j < coins.Count - 1; j++)
                {
                    if (coins[i] > coins[j])
                    {
                        var temp = coins[i];
                        coins[i] = coins[j];
                        coins[j] = temp;
                    }
                }
            }

            coins.ForEach(Console.WriteLine);
        }
    }
}
