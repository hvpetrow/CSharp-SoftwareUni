using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];

                if (command=="END")
                {
                    break;
                }
                else if (command=="swap")
                {

                    var row1 = long.Parse(input[1]);
                    var col1 = long.Parse(input[2]);
                    var row2 = long.Parse(input[3]);
                    var col2 = long.Parse(input[4]);
                               
                    if (row1<0 || row1 > matrix.GetLength(0)|| row2<0|| row2 > matrix.GetLength(0)
                        || col1<0||col1>matrix.GetLength(1) || col2<0 || col2 > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string firstChangingElement = matrix[row1, col1];
                    string secondChangingElement = matrix[row2, col2];

                    matrix[row1, col1] = secondChangingElement;
                    matrix[row2, col2] = firstChangingElement;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i,j] + " ");
                        }
                        Console.WriteLine();
                    }
                   
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
    }
}
