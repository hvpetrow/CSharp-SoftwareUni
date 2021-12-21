using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int[] coordinatesOfBomb = Console.ReadLine()
                                             .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(int.Parse)
                                             .ToArray();

            for (int i = 0; i < coordinatesOfBomb.Length; i += 2)
            {
                int bombRow = coordinatesOfBomb[i];
                int bombCol = coordinatesOfBomb[i + 1];

                if (IsInside(matrix, bombRow - 1, bombCol - 1))
                {
                    matrix[bombRow - 1, bombCol - 1] -= matrix[bombRow, bombCol];

                }
                if (IsInside(matrix, bombRow - 1, bombCol))
                {
                    matrix[bombRow - 1, bombCol] -= matrix[bombRow, bombCol];
                }
                if (IsInside(matrix, bombRow - 1, bombCol + 1))
                {
                    matrix[bombRow - 1, bombCol + 1] -= matrix[bombRow, bombCol];
                }
                if (IsInside(matrix, bombRow, bombCol - 1))
                {
                    matrix[bombRow, bombCol - 1] -= matrix[bombRow, bombCol];

                }
                if (IsInside(matrix, bombRow, bombCol))
                {
                    matrix[bombRow, bombCol] -= matrix[bombRow, bombCol];
                }
                if (IsInside(matrix, bombRow, bombCol + 1))
                {
                    matrix[bombRow, bombCol + 1] -= matrix[bombRow, bombCol];

                }
                if (IsInside(matrix, bombRow + 1, bombCol - 1))
                {
                    matrix[bombRow + 1, bombCol - 1] -= matrix[bombRow, bombCol];
                }
                if (IsInside(matrix, bombRow + 1, bombCol))
                {
                    matrix[bombRow + 1, bombCol] -= matrix[bombRow, bombCol];
                }
                if (IsInside(matrix, bombRow + 1, bombCol + 1))
                {
                    matrix[bombRow + 1, bombCol + 1] -= matrix[bombRow, bombCol];

                }
            }

            List<int> activeCells = FindActiveCells(matrix);
            Console.WriteLine($"Alive cells: {activeCells.Count}");
            Console.WriteLine($"Sum: {activeCells.Sum()}");
            PrintMatrix(matrix);
        }
        private static bool IsInside(int[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }
        public static List<int> FindActiveCells(int[,] squareMatrix)
        {
            List<int> activeCells = new List<int>();

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (squareMatrix[row, col] > 0)
                    {
                        activeCells.Add(squareMatrix[row, col]);
                    }
                }
            }

            return activeCells;
        }
        private static void PrintMatrix(int[,] squareMatrix)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    Console.Write(squareMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
