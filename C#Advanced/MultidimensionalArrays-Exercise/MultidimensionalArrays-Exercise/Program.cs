using System;
using System.Linq;

namespace MultidimensionalArrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];

                }
            }

            int firstDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    firstDiagonalSum += matrix[i, j];
                    i++;
                }
            }

            int secondDiagonalSum = 0;



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    secondDiagonalSum += matrix[i, j];
                    i++;
                }
            }

            int differ = Math.Abs(firstDiagonalSum - secondDiagonalSum);

            Console.WriteLine(differ);
        }
    }
}
