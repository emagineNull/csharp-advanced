using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            int[,] matrix = new int[5, 10];

            matrix[1, 2] = 100;

            Console.WriteLine(matrix[1, 2]);

            Console.WriteLine();

            int[,] initializedMatrix = {
                {1, 2, 3, 4},                
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(initializedMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(initializedMatrix.Length);

            Console.WriteLine();

            for (int row = 0; row < initializedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < initializedMatrix.GetLength(1); col++)
                {
                    Console.WriteLine(initializedMatrix[row, col] + " ");
                }
            }
        }
    }
}
