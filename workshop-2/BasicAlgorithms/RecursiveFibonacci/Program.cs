using System;

namespace RecursiveFibonacci
{
    class Program
    {
        private static int[] cache;

        static void Main(string[] args)
        {
            int n = 50;
            cache = new int[n + 1];

            var result = Fibonacci(50);
            Console.WriteLine(result);
        }

        public static int Fibonacci(int n)
        {
            if (cache[n] != 0)
            {
                return cache[n];
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            var result = Fibonacci(n - 1) + Fibonacci(n - 2);
            cache[n] = result;
            return result;
        }
    }
}
