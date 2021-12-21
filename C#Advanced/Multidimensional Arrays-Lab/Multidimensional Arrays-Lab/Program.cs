using System;
using System.Linq;

namespace Multidimensional_Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = ReadTheInput();

            int[,] matrix = new int[matrixSize[0],matrixSize[1]];
            int sum = 0;

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
          

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] inputArray = ReadTheInput();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = inputArray[col];
                    sum += matrix[rows, col];
                }
            }

            Console.WriteLine(sum);

        }

        private static int[] ReadTheInput()
        {
            return Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
