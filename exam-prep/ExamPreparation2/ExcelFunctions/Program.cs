using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] arr = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");

                arr[row] = input;
            }

            string[] commandParts = Console.ReadLine()
                .Split();

            string action = commandParts[0];
            string header = commandParts[1];

            int headerIndex = Array.IndexOf(arr[0], header);

            if (action == "hide")
            {
                arr.Where((x, i) => Array.IndexOf(x, i) != headerIndex);

                for (int row = 0; row < arr.Length; row++)
                {
                    Console.WriteLine(string.Join(" | ", arr[row]
                        .Where((x, i) => i != headerIndex)
                        .ToArray()));
                }
            }
            else if (action == "sort")
            {
                string[] headerRow = arr[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                arr = arr.OrderBy(x => x[headerIndex]).ToArray();

                foreach (var row in arr)
                {
                    if (row != headerRow)
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                }
            }
            else if (action == "filter")
            {
                string parameter = commandParts[2];
                string[] headerRow = arr[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i][headerIndex] == parameter)
                    {
                        Console.WriteLine(string.Join(" | ", arr[i]));
                    }
                }
            }
        }
    }
}
