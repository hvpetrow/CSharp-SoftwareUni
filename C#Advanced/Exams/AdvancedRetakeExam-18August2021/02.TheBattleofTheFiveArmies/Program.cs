using System;

namespace _02.TheBattleofTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armory = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());
            var matrix = new char[numberOfRows][];
            int armyRow = -1;
            int armyCol = -1;
            int mordorRow = -1;
            int mordorCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                matrix[row] = new char[line.Length];
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row][col] = line[col];
                    if (matrix[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                    else if (matrix[row][col] == 'M')
                    {
                        mordorRow = row;
                        mordorCol = col;
                    }
                }
            }

            while (true)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                int spawnRow = int.Parse(parts[1]);
                int spawnCol = int.Parse(parts[2]);
                armory--;
                matrix[spawnRow][spawnCol] = 'O';
                matrix[armyRow][armyCol] = '-';

                if (command == "up" && armyRow - 1 >= 0)
                {
                    armyRow--;
                }
                else if (command == "down" && armyRow + 1 < armyRow)
                {
                    armyRow++;
                }
                else if (command == "right" && armyCol + 1 < matrix[armyRow].Length)
                {
                    armyCol++;
                }
                else if (command == "left" && armyCol - 1 >= 0)
                {
                    armyCol--;
                }

                //already moved !

                if (matrix[armyRow][armyCol] == 'O')
                {
                    armory -= 2;
                }

                if (matrix[armyRow][armyCol] == 'M')
                {
                    matrix[armyRow][armyCol] ='-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armory}");

                    break;
                }

                if (armory<=0)
                {
                    matrix[armyRow][armyCol] = 'X';
                    Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                    break;
                }
                matrix[armyRow][armyCol] = 'A';
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                    //Console.WriteLine(new string(field[i]));
                }
                Console.WriteLine();

            }
        }
    }
}
