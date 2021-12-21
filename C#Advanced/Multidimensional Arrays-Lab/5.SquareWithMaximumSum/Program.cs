using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = ReadConsole();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] numbers = ReadConsole();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[r, col] = numbers[col];
                }
            }

            long max = long.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    var squareSum = matrix[i, j] +
                                    matrix[i + 1, j] +
                                    matrix[i, j + 1] +
                                    matrix[i + 1, j + 1];

                    if (squareSum>max)
                    {
                        max = squareSum;
                        maxSumRow = i;
                        maxSumCol = j;
                    }
                }
            }

            for (int r = maxSumRow; r < maxSumRow+2; r++)
            {
                for (int c = maxSumCol; c < maxSumCol+2; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine(max);
        }

        private static int[] ReadConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
