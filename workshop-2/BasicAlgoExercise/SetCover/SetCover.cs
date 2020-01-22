using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    class SetCover
    {
        public static void Main(string[] args)
        {
            int[] universe = new[] { 1, 3, 5, 7, 9, 11, 20, 30, 40 };
            int[][] sets = new[]
            {
                new[] { 20 },
                new[] { 1, 5, 20, 30 },
                new[] { 3, 7, 20, 30, 40 },
                new[] { 9, 30 },
                new[] { 11, 20, 30, 40 },
                new[] { 3, 7, 40 }
            };

            try
            {
                List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
                Console.WriteLine($"Sets to take ({selectedSets.Count}):");

                foreach (int[] set in selectedSets)
                {
                    Console.WriteLine($"{{ {string.Join(", ", set)} }}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            var selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                var currentSet = sets
                    .OrderByDescending(s => s.Count(universe.Contains))
                    .First();

                selectedSets.Add(currentSet);
                sets.Remove(currentSet);
                universe = universe.Where(n => !currentSet.Contains(n)).ToArray();
            }

            if (universe.Count == 0)
            {
                return selectedSets;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
