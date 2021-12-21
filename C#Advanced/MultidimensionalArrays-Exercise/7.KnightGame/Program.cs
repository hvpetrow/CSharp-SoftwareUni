using System;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSizeBoard = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[nSizeBoard,nSizeBoard];

            for (int rows = 0; rows < chessBoard.GetLength(0); rows++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[rows, col] = line[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                int maxAttacks = 0;
                int maxRow = 0;
                int maxCol = 0;
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentAttacks = 0;
                        if (chessBoard[row, col] != 'K')
                        {
                            continue;
                        }

                        if (ValidateThat(chessBoard, row - 2, col + 1)&& chessBoard[row - 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (ValidateThat(chessBoard, row - 1, col + 2)&&chessBoard[row - 1, col + 2] == 'K' )
                        {
                            currentAttacks++;
                        }
                        if (ValidateThat(chessBoard, row + 1, col + 2) &&chessBoard[row + 1, col + 2] == 'K' )
                        {
                            currentAttacks++;
                        }
                        if ( ValidateThat(chessBoard, row + 2, col + 1)&&chessBoard[row + 2, col + 1] == 'K' )
                        {
                            currentAttacks++;
                        }
                        if (ValidateThat(chessBoard, row + 2, col - 1)&&chessBoard[row + 2, col - 1] == 'K' )
                        {
                            currentAttacks++;
                        }
                        if ( ValidateThat(chessBoard, row + 1, col - 2)&&chessBoard[row + 1, col - 2] == 'K' )
                        {
                            currentAttacks++;
                        }
                        if (  ValidateThat(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (ValidateThat(chessBoard, row - 2, col - 1)&& chessBoard[row - 2, col - 1] == 'K' )
                        {
                            currentAttacks++;
                        }

                        if (currentAttacks > maxAttacks)
                        {
                            maxAttacks = currentAttacks;
                            maxRow = row;
                            maxCol = col;
                        }
                    }
                }
                if (maxAttacks==0)
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
                else
                {
                    chessBoard[maxRow, maxCol] = '0';
                    removedKnights++;

                }
            }
           
        }

        private static bool ValidateThat(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
