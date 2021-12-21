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
                matrix[blackPawnRow, blackPawnCol] = '-';

                if (whitePawnRow - 1 == blackPawnRow && whitePawnCol - 1 == blackPawnCol) // in case white capture the black pawn
                {
                    matrix[blackPawnRow, blackPawnCol] = '-';
                    isBlackCaptured = true;
                    whitePawnRow = blackPawnRow;
                    whitePawnCol = blackPawnCol;
                    matrix[blackPawnRow, blackPawnCol] = 'w';

                    break;
                }
                else if (blackPawnRow + 1 == whitePawnRow && blackPawnCol + 1 == whitePawnCol) // in case black capture the white pawn
                {
                    matrix[whitePawnRow, whitePawnCol] = '-';
                    blackPawnRow = whitePawnRow;
                    whitePawnCol = blackPawnCol;
                    matrix[whitePawnRow, whitePawnCol] = 'b';
                    isWhiteCaptured = true;
                    break;
                }
                whitePawnRow--;
                matrix[whitePawnRow, whitePawnCol] = 'w';          

                blackPawnRow++;
                matrix[blackPawnRow, blackPawnCol] = 'b';

                if (whitePawnRow == 0) // in case white pawn become a queen
                {
                    matrix[0, whitePawnCol] = 'w';

                    isWhitePawnQueen = true;
                    break;
                }
                else if (blackPawnRow == matrix.GetLength(0)) // case black pawn become a queen
                {
                    matrix[7, blackPawnCol] = 'b';

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
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'b')
                    {
                        blackPawnRow = row;
                        blackPawnCol = col;
                    }
                    else if (matrix[row, col] == 'w')
                    {
                        whitePawnRow = row;
                        whitePawnCol = col;
                    }
                }
            }
        }

        private static void ConvertToChessTable(ref int blackPawnRow, int blackPawnCol, ref int whitePawnRow, int whitePawnCol, out char colWhiteChar, out char blackChar)
        {
            if (whitePawnRow == 0)
            {
                whitePawnRow = 8;
            }
            else if (whitePawnRow == 1)
            {
                whitePawnRow = 7;
            }
            else if (whitePawnRow == 2)
            {
                whitePawnRow = 6;
            }
            else if (whitePawnRow == 3)
            {
                whitePawnRow = 5;
            }
            else if (whitePawnRow == 4)
            {
                whitePawnRow = 4;
            }
            else if (whitePawnRow == 5)
            {
                whitePawnRow = 3;
            }
            else if (whitePawnRow == 6)
            {
                whitePawnRow = 2;
            }
            else if (whitePawnRow == 7)
            {
                whitePawnRow = 1;
            }

            if (blackPawnRow == 7)
            {
                blackPawnRow = 1;
            }
            else if (blackPawnRow == 6)
            {
                blackPawnRow = 2;
            }
            else if (blackPawnRow == 5)
            {
                blackPawnRow = 3;
            }
            else if (blackPawnRow == 4)
            {
                blackPawnRow = 4;
            }
            else if (blackPawnRow == 3)
            {
                blackPawnRow = 5;
            }
            else if (blackPawnRow == 2)
            {
                blackPawnRow = 6;
            }
            else if (blackPawnRow == 1)
            {
                blackPawnRow = 7;
            }
            else if (blackPawnRow == 0)
            {
                blackPawnRow = 8;
            }

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