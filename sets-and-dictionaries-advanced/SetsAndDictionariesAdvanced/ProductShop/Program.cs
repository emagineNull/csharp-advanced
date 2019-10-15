using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, decimal>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                var productParts = command
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var shop = productParts[0];
                var product = productParts[1];
                var price = decimal.Parse(productParts[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, decimal>());
                }

                shops[shop].Add(product, price);

                command = Console.ReadLine();
            }

            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedShops)
            {
                var shop = kvp.Key;
                var products = kvp.Value;

                Console.WriteLine($"{shop}->");

                foreach (var productKvp in products)
                {
                    Console.WriteLine($"Product: {productKvp.Key}, Price: {productKvp.Value:f1}");
                }
            }
        }
    }
}
