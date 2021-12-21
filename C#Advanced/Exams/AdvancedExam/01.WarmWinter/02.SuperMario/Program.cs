using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lifes = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            int heroRow = 0;
            int heroCol = 0;
            int princessRow = 0;
            int princessCol = 0;
            bool isSuccessfull = false;
            bool isDead = false;

            FillTheField(rows, field, ref heroRow, ref heroCol, ref princessRow, ref princessCol);

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                int enemyRow = int.Parse(input[1]);
                int enemyCol = int.Parse(input[2]);
                field[enemyRow][enemyCol] = 'B';    //First spawn the enemy
                field[heroRow][heroCol] = '-';

                if (IsIndexValid(rows, field, heroRow, heroCol)) //Mario moves in direction
                {
                    if (command == "W" && IsIndexValid(rows, field, heroRow - 1, heroCol))
                    {
                        heroRow--;

                    }
                    else if (command == "S" && IsIndexValid(rows, field, heroRow + 1, heroCol))
                    {
                        heroRow++;
                    }
                    else if (command == "A" && IsIndexValid(rows, field, heroRow, heroCol - 1))
                    {
                        heroCol--;
                    }
                    else if (command == "D" && IsIndexValid(rows, field, heroRow, heroCol + 1))
                    {
                        heroCol++;
                    }
                }

                lifes--;    //lifes decreased 

                if (field[heroRow][heroCol] == 'P')    //check has saved the princess !?
                {
                    field[princessRow][princessCol] = '-';
                    isSuccessfull = true;
                    break;
                }

                if (lifes <= 0) //is hero alive ? 
                {
                    field[heroRow][heroCol] = 'X';
                    isDead = true;
                    break;
                }

                if (field[heroRow][heroCol] == 'B')    //fights the enemy
                {
                    lifes -= 2;
                    if (lifes <= 0)
                    {
                        field[heroRow][heroCol] = 'X';
                        isDead = true;
                        break;
                    }
                }
            }

            if (isDead == true)
            {
                Console.WriteLine($"Mario died at {heroRow};{heroCol}.");
            }
            else if (isSuccessfull == true)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifes}");
            }

            foreach (var row in field)
            {
                Console.WriteLine(String.Join("", row));
            }

        }

        private static void FillTheField(int rows, char[][] field, ref int heroRow, ref int heroCol, ref int princessRow, ref int princessCol)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                field[row] = new char[line.Length];
                for (int col = 0; col < line.Length; col++)
                {
                    field[row][col] = line[col];
                    if (field[row][col] == 'M')
                    {
                        heroRow = row;
                        heroCol = col;
                    }
                    else if (field[row][col] == 'P')
                    {
                        princessRow = row;
                        princessCol = col;
                    }
                }
            }
        }

        public static bool IsIndexValid(int rows, char[][] field, int heroRow, int heroCol)
        {
            return heroRow >= 0 && heroRow < rows && heroCol >= 0 && heroCol < field[heroRow].Length;
        }


    }
}
