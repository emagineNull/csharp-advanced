using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] colourAndItems = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string colour = colourAndItems[0];
                string[] items = colourAndItems[1].Split(',');

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }

                for (int j = 0; j < items.Length; j++)
                {
                    string currentItem = items[j];
                    if (!wardrobe[colour].ContainsKey(currentItem))
                    {
                        wardrobe[colour][currentItem] = 0;
                    }

                    wardrobe[colour][currentItem]++;
                }
            }

            string[] colorAnditemToLookFor = Console.ReadLine()
                .Split();

            string colorToLookFor = colorAnditemToLookFor[0];
            string itemToLookFor = colorAnditemToLookFor[1];

            foreach (var colour in wardrobe)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var kvp in colour.Value)
                {
                    if (colour.Key == colorToLookFor && kvp.Key == itemToLookFor)
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
