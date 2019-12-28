using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindSum(new int[] { 1, 2, 3, 4}, 0);
            Console.WriteLine(result);
        }

        public static int FindSum(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }

            return numbers[index] + FindSum(numbers, ++index);
        }
    }
}
