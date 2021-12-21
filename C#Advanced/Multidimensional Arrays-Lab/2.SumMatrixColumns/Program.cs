using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = ReadItS();

            int[,] matrix = new int[dimension[0], dimension[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = ReadItS();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }

                Console.WriteLine(sum);
            }
        }

        private static int[] ReadItS()
        {
            return Console.ReadLine()
                .Split(new string[] { ", " , " "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }
    }
}
