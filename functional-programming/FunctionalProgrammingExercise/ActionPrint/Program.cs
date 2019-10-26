using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> printer = x => Array.ForEach(x, Console.WriteLine);

            printer(input);
        }
    }
}
