using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currentNum))
                {
                    dict[currentNum] = 0;
                }

                dict[currentNum]++;
            }

            int evenTimesNum = 0;

            foreach (var num in dict)
            {
                if (num.Value % 2 == 0)
                {
                    evenTimesNum = num.Key;
                }
            }

            Console.WriteLine(evenTimesNum);
        }
    }
}
