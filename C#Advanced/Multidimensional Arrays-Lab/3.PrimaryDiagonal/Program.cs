using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            int diaSum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = numbers[col];
                }

            }

            for (int i = 0; i < squareMatrixSize; i++)
            {
                for (int j = 0; j < squareMatrixSize; j++)
                {
                    diaSum += matrix[i ,j];
                    i++;                 
                }
            }

            Console.WriteLine(diaSum);
        }
    }
}
