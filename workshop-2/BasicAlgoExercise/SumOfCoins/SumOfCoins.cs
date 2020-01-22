using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    class SumOfCoins
    {
        public static void Main(string[] args)
        {
            var availableCoins = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var targetSum = int.Parse(Console.ReadLine());

            try
            {
                var selectedCoins = ChooseCoins(availableCoins, targetSum);

                Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
                foreach (var selectedCoin in selectedCoins)
                {
                    Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var sortedCoins = coins
                .OrderByDescending(c => c)
                .ToList();

            var chosenCoins = new Dictionary<int, int>();
            var currentSum = 0;
            int coinIndex = 0;

            while (currentSum != targetSum && coinIndex < sortedCoins.Count)
            {
                var currentCoinValue = sortedCoins[coinIndex];
                var remainingSum = targetSum - currentSum;
                var numbersOfCoinsToTake = remainingSum / currentCoinValue;

                if (numbersOfCoinsToTake > 0)
                {
                    chosenCoins.Add(currentCoinValue, numbersOfCoinsToTake);
                    currentSum += (currentCoinValue * numbersOfCoinsToTake);
                }

                coinIndex++;
            }

            if (currentSum == targetSum)
            {
                return chosenCoins;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
