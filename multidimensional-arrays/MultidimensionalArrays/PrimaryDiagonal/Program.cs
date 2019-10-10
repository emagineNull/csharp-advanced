using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                var currentColumn = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < currentColumn.Length; j++)
                {
                    matrix[i, j] = currentColumn[j];
                }
            }

            int currentRow = 0;
            int currentCol = 0;

            int sum = 0;

            while (true)
            {
                if (currentRow >= matrix.GetLength(0) || currentCol >= matrix.GetLength(1))
                {
                    break;
                }
                
                sum += matrix[currentRow, currentCol];

                currentRow++;
                currentCol++;
            }

            Console.WriteLine(sum);
        }
    }
}
