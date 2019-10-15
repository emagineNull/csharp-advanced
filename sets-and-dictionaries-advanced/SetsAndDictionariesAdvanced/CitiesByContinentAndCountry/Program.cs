using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            var totalCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCommands; i++)
            {
                var input = Console.ReadLine().Split();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }

            foreach (var continentKVp in continents)
            {
                var continent = continentKVp.Key;
                var countries = continentKVp.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countryKvp in countries)
                {
                    var cities = countryKvp.Value;
                    Console.WriteLine($"  {countryKvp.Key} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
