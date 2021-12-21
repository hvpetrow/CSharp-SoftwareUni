using System;
using System.Linq;

namespace _2.SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int numberOfMatrix = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {            
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j]==matrix[i,j+1] && matrix[i, j] == matrix[i+1, j] && matrix[i, j]== matrix[i+1, j+1])
                    {
                        numberOfMatrix++;
                    }
                }
            }

            Console.WriteLine(numberOfMatrix);
        }
    }
}
