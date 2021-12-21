using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int numberOfCommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, rows];
            int playerRow = 0;
            int playerCol = 0;
            bool flag = false;
            FillTheMatrix(matrix, ref playerRow, ref playerCol);

            for (int turn = 0; turn < numberOfCommands; turn++)
            {
                string command = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';

                if (command == "up")
                {
                    playerRow--;
                    playerRow = OutFromUp(matrix, playerRow);
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow--;
                        playerRow = OutFromUp(matrix, playerRow);

                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow++;
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        flag = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }
                }
                else if (command == "down")
                {
                    playerRow++;
                    playerRow = OutFromDown(matrix, playerRow);
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow++;
                        playerRow = OutFromDown(matrix, playerRow);

                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow--;
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        flag = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }
                }
                else if (command == "right")
                {
                    playerCol++;
                    playerCol = OutFromRight(matrix, playerCol);
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol++;
                        playerCol = OutFromRight(matrix, playerCol);
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol--;
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        flag = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }
                }
                else if (command == "left")
                {
                    playerCol--;
                    playerCol = OutFromLeft(matrix, playerCol);
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol--;
                        playerCol = OutFromLeft(matrix, playerCol);
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol++;
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        flag = true;
                        break;
                    }
                }
                matrix[playerRow, playerCol] = 'f';
            }

            GameEnding(flag);
            Print(matrix);
        }

        private static void FillTheMatrix(char[,] matrix, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var chars = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }

        private static int OutFromRight(char[,] matrix, int playerCol)
        {
            if (playerCol > matrix.GetLength(1) - 1)
            {
                playerCol = 0;
            }

            return playerCol;
        }

        private static int OutFromDown(char[,] matrix, int playerRow)
        {
            if (playerRow > matrix.GetLength(0) - 1)
            {
                playerRow = 0;
            }

            return playerRow;
        }

        private static int OutFromUp(char[,] matrix, int playerRow)
        {
            if (playerRow < 0)
            {
                playerRow = matrix.GetLength(0) - 1;
            }

            return playerRow;
        }

        private static int OutFromLeft(char[,] matrix, int playerCol)
        {
            if (playerCol < 0)
            {
                playerCol = matrix.GetLength(1) - 1;
            }

            return playerCol;
        }

        private static void GameEnding(bool flag)
        {
            if (flag == true)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
        }

        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
