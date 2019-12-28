using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Factorial(4);
            Console.WriteLine(result);
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
