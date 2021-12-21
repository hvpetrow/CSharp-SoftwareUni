using System;
using System.Linq;

namespace _4.SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] symbols = Console.ReadLine().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = symbols[col];
                   
                }
            }

            char ch = char.Parse(Console.ReadLine());
            int searchedChAsInt = (int)ch;
            int rowCoordinate = 0;
            int colCoordinate = 0;
            bool flag = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {             
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentCharAscii = matrix[rows, col];

                    if (searchedChAsInt== currentCharAscii)
                    {
                        rowCoordinate = rows;
                        colCoordinate = col;
                        Console.WriteLine($"({rowCoordinate}, {colCoordinate})");
                        flag = true;
                        return;
                    }
                }
            }

            if (flag == false)
            {
             Console.WriteLine($"{ch} does not occur in the matrix ");

            }
        }
    }
}
