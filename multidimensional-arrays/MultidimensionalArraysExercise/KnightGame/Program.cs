using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[boardSize, boardSize];

            chessBoard = Populator(chessBoard);

            int removedKnightsCount = KnightsRemover(chessBoard);

            Console.WriteLine(removedKnightsCount);
        }

        public static int KnightsRemover(char[,] chessBoard)
        {
            int currentKnightsInDanger = 0;
            int maxKnightsInDanger = -1;
            int mostDangerousKnightRow = 0;
            int mostDangerousKnightCol = 0;
            int count = 0;

            while (true)
            {
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        if (chessBoard[row, col].Equals('K'))
                        {
                            // vertical and left
                            if (IsCellInMatrix(row - 2, col - 1, chessBoard))
                            {
                                if (chessBoard[row - 2, col - 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and right
                            if (IsCellInMatrix(row - 2, col + 1, chessBoard))
                            {
                                if (chessBoard[row - 2, col + 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and left
                            if (IsCellInMatrix(row + 2, col - 1, chessBoard))
                            {
                                if (chessBoard[row + 2, col - 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and right
                            if (IsCellInMatrix(row + 2, col + 1, chessBoard))
                            {
                                if (chessBoard[row + 2, col + 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal up and left
                            if (IsCellInMatrix(row - 1, col - 2, chessBoard))
                            {
                                if (chessBoard[row - 1, col - 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal up and right
                            if (IsCellInMatrix(row - 1, col + 2, chessBoard))
                            {
                                if (chessBoard[row - 1, col + 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal down and left
                            if (IsCellInMatrix(row + 1, col - 2, chessBoard))
                            {
                                if (chessBoard[row + 1, col - 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal down and right
                            if (IsCellInMatrix(row + 1, col + 2, chessBoard))
                            {
                                if (chessBoard[row + 1, col + 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                        }

                        if (currentKnightsInDanger > maxKnightsInDanger)
                        {
                            maxKnightsInDanger = currentKnightsInDanger;
                            mostDangerousKnightRow = row;
                            mostDangerousKnightCol = col;
                        }
                        currentKnightsInDanger = 0;
                    }
                }
                if (maxKnightsInDanger != 0)
                {
                    chessBoard[mostDangerousKnightRow, mostDangerousKnightCol] = 'O';
                    count++;
                    maxKnightsInDanger = 0;
                }
                else
                {
                    return count;
                }
            }
        }

        public static char[,] Populator(char[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] currenCol = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = currenCol[col];
                }
            }

            return chessBoard;
        }

        public static bool IsCellInMatrix(int row, int col, char[,] matrix)
        {
            if (0 <= row && row < matrix.GetLength(0) && 0 <= col && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
