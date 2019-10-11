using System;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] arr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                arr[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    arr[row][col] = int.Parse(input[col]);
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                string action = command[0];

                if (action == "END")
                {
                    break;
                }

                int argument1 = int.Parse(command[1]);
                int argument2 = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (argument1 < 0 || argument1 >= rows)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (argument2 < 0 || argument2 >= arr[argument1].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (action == "Add")
                {
                    arr[argument1][argument2] += value;
                }
                if (action == "Subtract")
                {
                    arr[argument1][argument2] -= value;
                }
            }

            foreach (int[] row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
