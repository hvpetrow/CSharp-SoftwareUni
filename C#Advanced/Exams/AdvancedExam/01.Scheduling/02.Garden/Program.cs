using System;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gardenSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = gardenSize[0];
            int cols = gardenSize[1];
            int[,] gardenMatrix = new int[rows, cols];

            for (int row = 0; row < gardenMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < gardenMatrix.GetLength(1); col++)
                {
                    gardenMatrix[row, col] = 0;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bloom Bloom Plow")
                {
                    break;
                }

                int[] plantingPositions = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int plantingRow = plantingPositions[0];
                int plantingCol = plantingPositions[1];

                if (plantingRow < 0 || plantingCol < 0 || plantingRow >= gardenMatrix.GetLength(0) || plantingCol >= gardenMatrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                gardenMatrix[plantingRow, plantingCol] = 1;

                for (int row = plantingRow + 1; row < gardenMatrix.GetLength(0); row++)
                {
                    gardenMatrix[row, plantingCol] += 1;
                }

                for (int row = plantingRow - 1; row >= 0; row--)
                {
                    gardenMatrix[row, plantingCol] += 1;
                }

                for (int col = plantingCol + 1; col < gardenMatrix.GetLength(1); col++)
                {
                    gardenMatrix[plantingRow, col] += 1;
                }

                for (int col = plantingCol - 1; col >= 0; col--)
                {
                    gardenMatrix[plantingRow, col] += 1;
                }
            }

            Print(gardenMatrix);
        }

        private static void Print(int[,] gardenMatrix)
        {
            for (int row = 0; row < gardenMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < gardenMatrix.GetLength(1); col++)
                {
                    Console.Write(gardenMatrix[row, col] + " ") ;            
                }
                Console.WriteLine();
            }
        }
    }
}
