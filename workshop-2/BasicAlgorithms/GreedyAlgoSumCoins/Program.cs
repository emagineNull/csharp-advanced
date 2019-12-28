using System;
using System.Collections.Generic;

namespace GreedyAlgoSumCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new List<int> { 5, 10, 2, 1, 1, 10, 5, 2, 1, 1, 10 };
            var sum = 18;

            coins.Sort();
            coins.Reverse();

            var currentCoinIndex = 0;

            var result = new List<int>();
            var finished = true;

            while (sum != 0)
            {
                if (currentCoinIndex >= coins.Count)
                {
                    finished = false;
                    break;
                }
                var currentCoin = coins[currentCoinIndex];

                if (sum - currentCoin < 0)
                {
                    currentCoinIndex++;
                    continue;
                }

                result.Add(currentCoin);
                sum -= currentCoin;
            }
        }
    }
}
