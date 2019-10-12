using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            int currentRowIndex = 0; 
            int currentColIndex = 0; 

            while (true)
            {
                if (currentRowIndex > size - 1)
                {
                    break;
                }

                primaryDiagonal += matrix[currentRowIndex, currentColIndex];

                currentRowIndex++;
                currentColIndex++;
            }

            currentRowIndex = 0;
            currentColIndex = size - 1;

            while (true)
            {
                if (currentRowIndex > size - 1)
                {
                    break;
                }

                secondaryDiagonal += matrix[currentRowIndex, currentColIndex];

                currentRowIndex++;
                currentColIndex--;
            }

            int difference = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(difference);
        }
    }
}
