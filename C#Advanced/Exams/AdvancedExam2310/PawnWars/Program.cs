using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];
            int blackPawnRow = -1;
            int blackPawnCol = -1;
            int whitePawnRow = -1;
            int whitePawnCol = -1;

            FillTheMatrix(matrix, ref blackPawnRow, ref blackPawnCol, ref whitePawnRow, ref whitePawnCol);

            bool isWhitePawnQueen = false;
            bool isBlackPawnQueen = false;
            bool isBlackCaptured = false;
            bool isWhiteCaptured = false;

            while (isBlackPawnQueen == false && isWhitePawnQueen == false && isBlackCaptured == false && isWhiteCaptured == false)
            {
                matrix[whitePawnRow, whitePawnCol] = '-';
                matrix[blackPawnRow-1, blackPawnCol] = '-';

                if (whitePawnRow + 1 == blackPawnRow && whitePawnCol + 1 == blackPawnCol) // in case white capture the black pawn
                {
                    isBlackCaptured = true;
                    break;
                }

                whitePawnRow--;
                matrix[whitePawnRow, whitePawnCol] = 'w';

                if (blackPawnRow - 1 == whitePawnRow && blackPawnCol - 1 == whitePawnCol) // in case black capture the white pawn
                {
                    isWhiteCaptured = true;
                }

                blackPawnRow++;
                matrix[blackPawnRow, blackPawnCol] = 'b';

                if (whitePawnRow == 8) // in case white pawn become a queen
                {
                    isWhitePawnQueen = true;
                    break;
                }
                else if (blackPawnRow == 1) // case black pawn become a queen
                {
                    isBlackPawnQueen = true;
                    break;
                }


                Console.WriteLine();
                Print(matrix);
            }

            char colWhiteChar, blackChar;
            ConvertToChessTable(ref blackPawnRow, blackPawnCol, ref whitePawnRow, whitePawnCol, out colWhiteChar, out blackChar);

            if (isWhiteCaptured == true)
            {
                Console.WriteLine($"Game over! Black capture on {colWhiteChar}{whitePawnRow}.");
            }
            else if (isBlackCaptured == true)
            {
                Console.WriteLine($"Game over! White capture on {blackChar}{blackPawnRow}.");
            }
            else if (isWhitePawnQueen == true)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {colWhiteChar}{whitePawnRow}.");
            }
            else if (isBlackPawnQueen == true)
            {
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {blackChar}{blackPawnRow}.");
            }
        }

        private static void FillTheMatrix(char[,] matrix, ref int blackPawnRow, ref int blackPawnCol, ref int whitePawnRow, ref int whitePawnCol)
        {
            for (int row = 8; row >= 1; row--)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row-1, col] = line[col];
                    if (matrix[row-1, col] == 'b')
                    {
                        blackPawnRow = row;
                        blackPawnCol = col;
                    }
                    else if (matrix[row-1, col] == 'w')
                    {
                        whitePawnRow = row;
                        whitePawnCol = col;
                    }
                }
            }
        }

        private static void ConvertToChessTable(ref int blackPawnRow, int blackPawnCol, ref int whitePawnRow, int whitePawnCol, out char colWhiteChar, out char blackChar)
        {
           
            colWhiteChar = default;
            if (whitePawnCol == 0)
            {
                colWhiteChar = 'a';
            }
            else if (whitePawnCol == 1)
            {
                colWhiteChar = 'b';
            }
            else if (whitePawnCol == 2)
            {
                colWhiteChar = 'c';
            }
            else if (whitePawnCol == 3)
            {
                colWhiteChar = 'd';
            }
            else if (whitePawnCol == 4)
            {
                colWhiteChar = 'e';
            }
            else if (whitePawnCol == 3)
            {
                colWhiteChar = 'f';
            }
            else if (whitePawnCol == 3)
            {
                colWhiteChar = 'g';
            }
            else if (whitePawnCol == 3)
            {
                colWhiteChar = 'h';
            }

            blackChar = default;
            if (blackPawnCol == 0)
            {
                blackChar = 'a';
            }
            else if (blackPawnCol == 1)
            {
                blackChar = 'b';
            }
            else if (blackPawnCol == 2)
            {
                blackChar = 'c';
            }
            else if (blackPawnCol == 3)
            {
                blackChar = 'd';
            }
            else if (blackPawnCol == 4)
            {
                blackChar = 'e';
            }
            else if (blackPawnCol == 5)
            {
                blackChar = 'f';
            }
            else if (blackPawnCol == 6)
            {
                blackChar = 'g';
            }
            else if (blackPawnCol == 7)
            {
                blackChar = 'h';
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
