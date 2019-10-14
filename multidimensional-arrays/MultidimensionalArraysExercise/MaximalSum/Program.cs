using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentCol = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            int maxSum = int.MinValue;
            int[,] maxSumMatrix = new int[3, 3];

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] +
                        matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] +
                        matrix[row + 2, col] + matrix[row + 1, col] + matrix[row, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        maxSumMatrix[0, 0] = matrix[row, col];
                        maxSumMatrix[0, 1] = matrix[row, col + 1];
                        maxSumMatrix[0, 2] = matrix[row, col + 2];
                        maxSumMatrix[1, 0] = matrix[row + 1, col];
                        maxSumMatrix[1, 1] = matrix[row + 1, col + 1];
                        maxSumMatrix[1, 2] = matrix[row + 1, col + 2];
                        maxSumMatrix[2, 0] = matrix[row + 2, col];
                        maxSumMatrix[2, 1] = matrix[row + 2, col + 1];
                        maxSumMatrix[2, 2] = matrix[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < maxSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxSumMatrix.GetLength(1); col++)
                {
                    Console.Write(maxSumMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
