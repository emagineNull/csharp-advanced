using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                var currentCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < currentCol.Length; j++)
                {
                    matrix[i, j] = currentCol[j];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
