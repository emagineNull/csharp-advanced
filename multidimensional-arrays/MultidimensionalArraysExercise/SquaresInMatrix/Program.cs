using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] currentInput = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentInput[col];
                }
            }

            int counter = 0;

            char currentSquareCell0 = ' ';
            char currentSquareCell1 = ' ';
            char currentSquareCell2 = ' ';
            char currentSquareCell3 = ' ';

            int currentRow = 0;
            int currentCol = 0;

            //while (true)
            //{
            //    if (currentRow > rows - 1 || currentCol )
            //    {

            //    }
            //}

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int[,] currentMatrix = new int[2, 2];


                }
            }
        }
    }
}
