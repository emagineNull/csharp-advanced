using System;
using System.Linq;

namespace MatrixShuffling
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

            string[,] rectMatrix =  new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentCol = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    rectMatrix[row, col] = currentCol[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                {
                    break;
                }

                if (command.Length != 5 || command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = 0;
                int row2 = 0;
                int col1 = 0;
                int col2 = 0;

                try
                {
                    row1 = int.Parse(command[1]);
                    col1 = int.Parse(command[2]);
                    row2 = int.Parse(command[3]);
                    col2 = int.Parse(command[4]);
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (row1 >= rows || row2 >= rows || col1 >= cols || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string temp = string.Empty;

                temp = rectMatrix[row1, col1];
                rectMatrix[row1, col1] = rectMatrix[row2, col2];
                rectMatrix[row2, col2] = temp;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(rectMatrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
