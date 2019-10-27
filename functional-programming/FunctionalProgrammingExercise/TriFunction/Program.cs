using System;
using System.Linq;
using System.Collections.Generic;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isGreater = (a, b) => a.Sum(c => c) >= b;

            Func<Func<string, int, bool>, List<string>, string> returnFirst = (a, b) => b.FirstOrDefault(s => a(s, n));

            string result = returnFirst(isGreater, names);

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(string.Empty);
            }
        }
    }
}
