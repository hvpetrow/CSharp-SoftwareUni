using System;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[] charSnake = Console.ReadLine().ToCharArray();
            char[,] matrix = new char[sizes[0], sizes[1]];
            int diff = charSnake.Length - matrix.GetLength(1);
            bool flag = true;
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (flag)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = charSnake[counter++];

                        if (counter==charSnake.Length)
                        {
                            counter = 0;
                        }
                    }
                    flag = false;
                }

                else
                {
                    
                        for (int k = matrix.GetLength(1) - 1; k >= 0; k--)
                        {
                            if (counter == charSnake.Length)
                            {
                                counter = 0;
                            }
                        }
                        flag = true;
                    

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
 
                }
                Console.WriteLine();
                
            }
        }
    }
}
