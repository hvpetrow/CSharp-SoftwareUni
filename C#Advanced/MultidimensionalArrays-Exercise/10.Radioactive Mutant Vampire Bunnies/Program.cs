using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[sizeOfMatrix[0], sizeOfMatrix[1]];

            int playerRow = 0;
            int playerCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];

                    if (matrix[i, j] == 'P');
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }

            string directions = Console.ReadLine();

            int nextCol = 0;
            int nextRow = 0;


         
            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case 'L':
                        nextCol = -1;
                        break;

                    case 'R':
                        nextCol = 1;
                        break;

                    case 'U':
                        nextRow = -1;
                        break;

                    case 'D':
                        nextRow = 1;
                        break;

                    default:
                        break;
                }
                matrix[playerRow, playerCol] = '.';
                playerRow += nextRow;
                playerCol += nextCol;
                if (!IsInside(matrix,playerRow,playerCol))
                {
                    Console.WriteLine("Won");
                }
                else if (matrix[playerRow,playerCol]=='B')
                {
                    Console.WriteLine("Dead");
                }
                else
                {
                matrix[playerRow, playerCol] = 'P';

                }
                List<int[]> bunniesCoordinates = new List<int[]>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i,j] == 'B')
                        {
                            bunniesCoordinates.Add(new int[] { i, j });
                        }
                    }
                }

                foreach (var item in bunniesCoordinates)
                {
                    int bunnyRow = item[0];
                    int bunnyCol = item[1];
                    if (IsInside(matrix,bunnyRow+1,bunnyCol))
                    {
                        if (matrix[bunnyRow + 1, bunnyCol]=='P')
                        {

                        }
                    matrix[bunnyRow + 1, bunnyCol] = 'B';

                    }
                    else if (IsInside(matrix, bunnyRow - 1, bunnyCol))
                    {
                        if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                        {

                        }
                        matrix[bunnyRow -1, bunnyCol] = 'B';

                    }
                    else if (IsInside(matrix, bunnyRow, bunnyCol-1))
                    {
                        if (matrix[bunnyRow, bunnyCol-1] == 'P')
                        {

                        }
                        matrix[bunnyRow, bunnyCol-1] = 'B';

                    }
                    else if (IsInside(matrix, bunnyRow, bunnyCol+1))
                    {
                        if (matrix[bunnyRow, bunnyCol +1] == 'P')
                        {

                        }
                        matrix[bunnyRow, bunnyCol+1] = 'B';

                    }
                }
                PrintIt(matrix);
                Console.WriteLine();
            }

        }

        private static void PrintIt(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
