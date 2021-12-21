using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            long sum = 0;
            long max = long.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
                

            for (int i = 0; i < matrix.GetLength(0)-2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-2; j++)
                {
                    sum = matrix[i, j] + matrix[i,j+1]+ matrix[i,j+2]+
                        matrix[i+1, j]  + matrix[i+1, j+1]+ matrix[i+1, j+2]+ 
                        matrix[i+2, j] + matrix[i+2, j+1]+ matrix[i+2, j+2];
                    if (sum>max)
                    {
                        max=sum;
                        maxSumRow = i;
                        maxSumCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {max}");

            for (int i = maxSumRow; i < maxSumRow+3; i++)
            {
                for (int j = maxSumCol; j < maxSumCol+3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine(); 

            }
        }
    }
}
