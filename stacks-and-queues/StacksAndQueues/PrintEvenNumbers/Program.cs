using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input);

            List<int> evenNums = new List<int>();

            while (queue.Any())
            {
                var currentNumber = queue.Dequeue();

                if (currentNumber % 2 == 0)
                {
                    evenNums.Add(currentNumber);
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
