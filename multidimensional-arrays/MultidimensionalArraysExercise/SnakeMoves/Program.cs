using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows, cols];

            Queue<char> queue = new Queue<char>(snake);

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (!queue.Any())
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }

                        matrix[row, col] = queue.Dequeue();
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (!queue.Any())
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }

                        matrix[row, col] = queue.Dequeue();
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
