using System;
using System.Linq;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[,] field = new char[rows,rows];
            int countFirstPlayerShips = 0;
            int countsecondPlayerShips = 0;
            string[] attacksCoordinates = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

            for (int row = 0; row < field.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = char.Parse(line[col]);
                    if (field[row,col]=='>')
                    {
                        countFirstPlayerShips++;
                    }
                    else if (field[row,col]=='<')
                    {
                        countsecondPlayerShips++;
                    }
                }
            }
          int  firstPlayerSunkedShips = 0;
          int  secondPlayerSunkedShips = 0;

            foreach (var attack in attacksCoordinates)
            {
                string[] splittedAttackCoordinates = attack.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int rowAttack = int.Parse(splittedAttackCoordinates[0]);
                int colAttack = int.Parse(splittedAttackCoordinates[1]);

                if (IsInvalid(rows, field, rowAttack, colAttack))
                {
                    continue;
                }
                if (field[rowAttack, colAttack] == '>')
                {
                    field[rowAttack, colAttack] = 'X';
                    firstPlayerSunkedShips++;
                    countsecondPlayerShips--;
                }
                else BombDevastation(rows, field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips, rowAttack, colAttack);
                if (countFirstPlayerShips == 0 || countsecondPlayerShips == 0)
                {
                    break;
                }
            }

            if (countsecondPlayerShips==0)
            {
                Console.WriteLine($"Player One has won the game! {secondPlayerSunkedShips+firstPlayerSunkedShips} ships have been sunk in the battle.");
            }
            else if(countFirstPlayerShips==0)
            {
                Console.WriteLine($"Player Two has won the game! {firstPlayerSunkedShips+secondPlayerSunkedShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {countFirstPlayerShips} ships left. Player Two has {countsecondPlayerShips} ships left.");
            }
        }

        private static void BombDevastation(int rows, char[,] field, ref int countFirstPlayerShips, ref int countsecondPlayerShips, ref int firstPlayerSunkedShips, ref int secondPlayerSunkedShips, int rowAttack, int colAttack)
        {
            if (field[rowAttack, colAttack] == '<')
            {
                field[rowAttack, colAttack] = 'X';
                secondPlayerSunkedShips++;
                countFirstPlayerShips--;
            }
            else if (field[rowAttack, colAttack] == '#')
            {
                if (!IsInvalid(rows, field, rowAttack - 1, colAttack))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips, rowAttack - 1, colAttack);

                    field[rowAttack - 1, colAttack] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack + 1, colAttack))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips, rowAttack + 1, colAttack);
                    field[rowAttack + 1, colAttack] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack + 1, colAttack + 1))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips,
                        rowAttack + 1, colAttack + 1);

                    field[rowAttack + 1, colAttack + 1] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack - 1, colAttack + 1))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips,
                        rowAttack - 1, colAttack + 1);

                    field[rowAttack - 1, colAttack + 1] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack + 1, colAttack - 1))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips,
                        rowAttack + 1, colAttack - 1);

                    field[rowAttack + 1, colAttack - 1] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack - 1, colAttack - 1))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips
                        , rowAttack - 1, colAttack - 1);

                    field[rowAttack - 1, colAttack - 1] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack, colAttack + 1))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips
                        , rowAttack, colAttack + 1);

                    field[rowAttack, colAttack + 1] = 'X';
                }
                if (!IsInvalid(rows, field, rowAttack, colAttack - 1))
                {
                    MineDestroyings(field, ref countFirstPlayerShips, ref countsecondPlayerShips, ref firstPlayerSunkedShips, ref secondPlayerSunkedShips
                        , rowAttack, colAttack - 1);

                    field[rowAttack, colAttack - 1] = 'X';
                }
            }
        }

        private static void MineDestroyings(char[,] field, ref int countFirstPlayerShips, ref int countsecondPlayerShips, ref int firstPlayerSunkedShips, ref int secondPlayerSunkedShips, int rowAttack, int colAttack)
        {
            if (field[rowAttack , colAttack] == '>')
            {
                firstPlayerSunkedShips++;
                countsecondPlayerShips--;
            }
            else if (field[rowAttack , colAttack] == '<')
            {
                secondPlayerSunkedShips++;
                countFirstPlayerShips--;
            }
        }

        private static bool IsInvalid(int rows, char[,] field, int rowAttack, int colAttack)
        {
            return rowAttack > rows - 1 || rowAttack < 0 || colAttack > rows - 1 || colAttack < 0 || field[rowAttack, colAttack] == '*';
        }
    }
}
