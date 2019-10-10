using System;
using System.Linq;

namespace SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().ToCharArray();

                for (int j = 0; j < current.Length; j++)
                {
                    matrix[i, j] = current[j];
                }
            }

            var symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
