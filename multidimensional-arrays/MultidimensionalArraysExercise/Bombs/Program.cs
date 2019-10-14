using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            if (matrixSize == 0)
            {
                Console.WriteLine("Alive cells: " + 0);
                Console.WriteLine("Sum: " + 0);
                Console.WriteLine(0);
                return;
            }

            int[,] matrix = new int[matrixSize, matrixSize];

            matrix = Populate(matrix);

            string[] bombs = Console.ReadLine().Split();

            Queue<string> bombsQueue = new Queue<string>(bombs); 

            while (true)
            {
                if (!bombsQueue.Any())
                {
                    break;
                }

                int[] currentBomb = bombsQueue.Dequeue()
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                int currentRow = currentBomb[0];
                int currentCol = currentBomb[1];

                if (matrix[currentRow, currentCol] <= 0)
                {
                    continue;
                }

                int bombValue = matrix[currentRow, currentCol];

                matrix[currentRow, currentCol] = 0;

                matrix = Bombing(matrix, currentRow, currentCol, bombValue);
            }

            Printer(matrix);
        }

        public static int[,] Populate(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentCol = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            return matrix;
        }

        public static int[,] Bombing(int[,] matrix, int currentRow, int currentCol, int bombValue)
        {
            if (currentRow - 1 >= 0 && currentCol - 1 >= 0 && matrix[currentRow - 1, currentCol - 1] > 0)
            {
                matrix[currentRow - 1, currentCol - 1] -= bombValue;
            }
            if (currentRow + 1 < matrix.GetLength(0) && currentCol + 1 < matrix.GetLength(1) 
                && matrix[currentRow + 1, currentCol + 1] > 0)
            {
                matrix[currentRow + 1, currentCol + 1] -= bombValue;
            }
            if (currentCol + 1 < matrix.GetLength(1) && matrix[currentRow, currentCol + 1] > 0)
            {
                matrix[currentRow, currentCol + 1] -= bombValue;
            }
            if (currentCol - 1 >= 0 && matrix[currentRow, currentCol - 1] > 0)
            {
                matrix[currentRow, currentCol - 1] -= bombValue;
            }
            if (currentRow - 1 >= 0 && matrix[currentRow - 1, currentCol] > 0)
            {
                matrix[currentRow - 1, currentCol] -= bombValue;
            }
            if (currentRow + 1 < matrix.GetLength(0) && currentCol - 1 >= 0 && matrix[currentRow + 1, currentCol - 1] > 0)
            {
                matrix[currentRow + 1, currentCol - 1] -= bombValue;
            }
            if (currentRow - 1 >= 0 && currentCol + 1 < matrix.GetLength(1) && matrix[currentRow - 1, currentCol + 1] > 0)
            {
                matrix[currentRow - 1, currentCol + 1] -= bombValue;
            }
            if (currentRow + 1 < matrix.GetLength(0) && matrix[currentRow + 1, currentCol] > 0)
            {
                matrix[currentRow + 1, currentCol] -= bombValue;
            }

            return matrix;
        }

        public static void Printer(int[,] matrix)
        {
            int aliveCellsCount = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCellsCount++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
