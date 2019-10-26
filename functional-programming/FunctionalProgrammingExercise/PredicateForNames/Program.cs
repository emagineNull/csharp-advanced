using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> checker = x => x.Length <= nameLength;
            Func<string[], string[]> filter = x => x.Where(y => checker(y)).ToArray();

            names = filter(names);

            Array.ForEach(names, Console.WriteLine);
        }
    }
}
