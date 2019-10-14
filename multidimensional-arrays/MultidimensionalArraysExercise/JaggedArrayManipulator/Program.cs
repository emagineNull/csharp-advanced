using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] arr = new double[rows][];

            arr = Populator(arr);
            arr = Analyzer(arr);
            arr = Manipulator(arr);
            
            Printer(arr);
        }

        public static double[][] Populator(double[][] arr)
        {
            for (int row = 0; row < arr.Length; row++)
            {
                double[] currentArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                arr[row] = new double[currentArr.Length];

                for (int col = 0; col < currentArr.Length; col++)
                {
                    arr[row][col] = currentArr[col];
                }
            }

            return arr;
        }

        public static double[][] Analyzer(double[][] arr)
        {
            for (int row = 0; row < arr.Length - 1; row++)
            {
                if (arr[row].Length == arr[row + 1].Length)
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        arr[row][col] *= 2;
                        arr[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        arr[row][col] /= 2;
                    }
                    for (int col = 0; col < arr[row + 1].Length; col++)
                    {
                        arr[row + 1][col] /= 2;
                    }
                }
            }

            return arr;
        }

        public static double[][] Manipulator(double[][] arr)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] action = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string operation = action[0];
                int row = int.Parse(action[1]);
                int col = int.Parse(action[2]);
                int value = int.Parse(action[3]);

                if (operation == "Add")
                {
                    try
                    {
                        arr[row][col] += value;
                    }
                    catch
                    {
                        continue;
                    }
                }
                if (operation == "Subtract")
                {
                    try
                    {
                        arr[row][col] -= value;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            return arr;
        }

        public static void Printer(double[][] arr)
        {
            for (int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    Console.Write(arr[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
