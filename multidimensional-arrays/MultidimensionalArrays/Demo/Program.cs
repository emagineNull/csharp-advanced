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

            Console.WriteLine();

            int[] arr0 = new int[5];
            int[] arr1 = new int[10];
            int[] arr2 = new int[7];
            int[] arr3 = new int[9];

            int[][] arr = new int[4][];
            arr[0] = new int[5];
            arr[1] = new int[10];
            arr[2] = new int[7];
            arr[3] = new int[9];

            arr[1][3] = 100;

            Console.WriteLine(arr[1][3]);
            Console.WriteLine(arr[1].Length);

        }
    }
}
