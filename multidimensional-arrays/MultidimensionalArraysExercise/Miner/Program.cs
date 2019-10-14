using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            long fieldSize = long.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();

            char[,] field = new char[fieldSize, fieldSize];

            long[] startingPoint = new long[2];
            long totalCoalCounter = 0;

            for (long row = 0; row < fieldSize; row++)
            {
                char[] currentCol = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (long col = 0; col < fieldSize; col++)
                {
                    if (currentCol[col] == 's')
                    {
                        startingPoint[0] = row;
                        startingPoint[1] = col;
                    }
                    if (currentCol[col] == 'c')
                    {
                        totalCoalCounter++;
                    }

                    field[row, col] = currentCol[col];
                }
            }

            long collectedCoalCounter = 0;

            long currentRowIndex = startingPoint[0];
            long currentColIndex = startingPoint[1];

            long leftCoalCounter = totalCoalCounter;

            Queue<string> commandsQueue = new Queue<string>(commands);

            while (true)
            {
                if (leftCoalCounter == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRowIndex}, {currentColIndex})");
                    return;
                }

                if (!commandsQueue.Any())
                {
                    Console.WriteLine($"{leftCoalCounter} coals left. ({currentRowIndex}, {currentColIndex})");
                    return;
                }

                string currentCommand = commandsQueue.Dequeue();

                if (currentCommand == "left")
                {
                    if (currentColIndex - 1 < 0)
                    {
                        continue;
                    }
                    if (field[currentRowIndex, currentColIndex - 1] == '*' || field[currentRowIndex, currentColIndex - 1] == 's')
                    {
                        currentColIndex -= 1;
                    }
                    else if (field[currentRowIndex, currentColIndex - 1] == 'c')
                    {
                        leftCoalCounter--;
                        collectedCoalCounter++;
                        field[currentRowIndex, currentColIndex - 1] = '*';
                        currentColIndex -= 1;
                    }
                    else if (field[currentRowIndex, currentColIndex - 1] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRowIndex}, {currentColIndex - 1})");
                        return;
                    }
                }
                else if (currentCommand == "right")
                {
                    if (currentColIndex + 1 >= field.GetLongLength(1))
                    {
                        continue;
                    }
                    if (field[currentRowIndex, currentColIndex + 1] == '*' || field[currentRowIndex, currentColIndex + 1] == 's')
                    {
                        currentColIndex += 1;
                    }
                    else if (field[currentRowIndex, currentColIndex + 1] == 'c')
                    {
                        leftCoalCounter--;
                        collectedCoalCounter++;
                        field[currentRowIndex, currentColIndex + 1] = '*';
                        currentColIndex += 1;
                    }
                    else if (field[currentRowIndex, currentColIndex + 1] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRowIndex}, {currentColIndex + 1})");
                        return;
                    }
                }
                else if (currentCommand == "up")
                {
                    if (currentRowIndex - 1 < 0)
                    {
                        continue;
                    }
                    if (field[currentRowIndex - 1, currentColIndex] == '*' || field[currentRowIndex - 1, currentColIndex] == 's')
                    {
                        currentRowIndex -= 1;
                    }
                    else if (field[currentRowIndex - 1, currentColIndex] == 'c')
                    {
                        leftCoalCounter--;
                        collectedCoalCounter++;
                        field[currentRowIndex - 1, currentColIndex] = '*';
                        currentRowIndex -= 1;
                    }
                    else if (field[currentRowIndex - 1, currentColIndex] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRowIndex - 1}, {currentColIndex})");
                        return;
                    }
                }
                else if (currentCommand == "down")
                {
                    if (currentRowIndex + 1 >= field.GetLongLength(0))
                    {
                        continue;
                    }
                    if (field[currentRowIndex + 1, currentColIndex] == '*' || field[currentRowIndex + 1, currentColIndex] == 's')
                    {
                        currentRowIndex += 1;
                    }
                    else if (field[currentRowIndex + 1, currentColIndex] == 'c')
                    {
                        leftCoalCounter--;
                        collectedCoalCounter++;
                        field[currentRowIndex + 1, currentColIndex] = '*';
                        currentRowIndex += 1;
                    }
                    else if (field[currentRowIndex + 1, currentColIndex] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRowIndex + 1}, {currentColIndex})");
                        return;
                    }
                }
            }
        }
    }
}
