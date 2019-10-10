using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = n[0];
            var cols = n[1];

            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var currentColumn = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < currentColumn.Length; j++)
                {
                    matrix[i, j] = currentColumn[j];
                }
            }

            var maxSum = int.MinValue;
            var maxRowIndex = 0;
            var maxColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRowIndex, maxColIndex]} {matrix[maxRowIndex, maxColIndex + 1]}");
            Console.WriteLine($"{matrix[maxRowIndex + 1, maxColIndex]} {matrix[maxRowIndex + 1, maxColIndex + 1]}");
            Console.WriteLine($"{maxSum}");
        }
    }
}
