using System;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[,] field = new char[rows, rows];
            int myPostionRow = -1;
            int myPositionCol = -1;
            int firstPillarRow = -1;
            int firstPillarCol = -1;
            int secondPillarRow = -1;
            int secondPillarCol = -1;
            int pillarCounter = 0;
            int sumMoney = 0;
            bool IsOutOfBakery = false;

            FillData(field, ref myPostionRow, ref myPositionCol, ref firstPillarRow, ref firstPillarCol, ref secondPillarRow, ref secondPillarCol, ref pillarCounter);

            while (sumMoney<50 && IsOutOfBakery==false)
            {
                string command = Console.ReadLine();
                field[myPostionRow, myPositionCol] = '-';

                switch (command)
                {
                    case "up":
                        myPostionRow--;
                        break;
                    case "down":
                        myPostionRow++;
                        break;
                    case "right":
                        myPositionCol++;
                        break;
                    case "left":
                        myPositionCol--;
                        break;
                }

                if (myPostionRow < 0 || myPositionCol < 0 || myPostionRow >= field.GetLength(0) || myPositionCol >= field.GetLength(1))
                {
                    IsOutOfBakery = true;
                    break;
                }

                if (IsClientThere(field, myPostionRow, myPositionCol))
                {
                    char symbol = field[myPostionRow, myPositionCol];
                    sumMoney += symbol - '0';
                    if (sumMoney >= 50)
                    {
                        break;
                    }
                }

                if (field[myPostionRow, myPositionCol] == 'O')
                {
                    if (myPostionRow == firstPillarRow && myPositionCol == firstPillarCol)
                    {
                        field[firstPillarRow, firstPillarCol] = '-';
                        myPostionRow = secondPillarRow;
                        myPositionCol = secondPillarCol;
                    }
                    else if (myPostionRow == secondPillarRow && myPositionCol == secondPillarCol)
                    {
                        field[secondPillarRow, secondPillarCol] = '-';
                        myPostionRow = firstPillarRow;
                        myPositionCol = firstPillarCol;
                    }
                }

                field[myPostionRow, myPositionCol] = 'S';
            }
            if (IsOutOfBakery == true)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else if (sumMoney >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {sumMoney}");

            Print(field, myPostionRow, myPositionCol);
        }

        private static bool IsClientThere(char[,] field, int myPostionRow, int myPositionCol)
        {
            if (char.IsDigit(field[myPostionRow, myPositionCol]))
            {
                return true;
            }
            return false;
        }

        private static void Print(char[,] field, int myRow, int myCol)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static void FillData(char[,] field, ref int myPostionRow, ref int myPositionCol, ref int firstPillarRow, ref int firstPillarCol, ref int secondPillarRow, ref int secondPillarCol, ref int pillarCounter)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = line[col];
                    if (field[row, col] == 'S')
                    {
                        myPostionRow = row;
                        myPositionCol = col;
                    }
                    else if (field[row, col] == 'O')
                    {
                        pillarCounter++;
                        if (pillarCounter == 1)
                        {
                            firstPillarRow = row;
                            firstPillarCol = col;
                        }
                        else
                        {
                            secondPillarRow = row;
                            secondPillarCol = col;
                        }
                    }
                }
            }
        }
    }
}
