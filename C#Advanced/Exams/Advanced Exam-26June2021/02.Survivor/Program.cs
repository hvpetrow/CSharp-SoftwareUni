using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                field[row] = line;
            }

            int collectedTokens = 0;
            int opponentsTokens = 0;


            while (true)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                if (command == "Find")
                {
                    int movingRow = int.Parse(parts[1]);
                    int movingCol = int.Parse(parts[2]);
                
                    if (movingRow >= 0 && movingRow < rows && movingCol >= 0 && movingCol < field[movingRow].Length && field[movingRow][movingCol] == 'T') //Check It ! 
                    {
                        collectedTokens++;
                        field[movingRow][movingCol] = '-';
                    }
                }
                else if (command == "Opponent")
                {
                    int movingRow = int.Parse(parts[1]);
                    int movingCol = int.Parse(parts[2]);
                    string direction = parts[3];

                    if (movingRow >= 0 && movingRow < rows && movingCol >= 0 && movingCol < field[movingRow].Length)
                    {
                        if (field[movingRow][movingCol] == 'T')
                        {
                            opponentsTokens++;
                            field[movingRow][movingCol] = '-';
                        }

                        if (direction == "up")
                        {

                            for (int i = 0; i < 3; i++)
                            {
                                movingRow--;
                                if (movingRow >= 0 && movingRow < rows && movingCol >= 0 && movingCol < field[movingRow].Length)
                                {
                                    if (field[movingRow][movingCol] == 'T')
                                    {
                                        opponentsTokens++;
                                        field[movingRow][movingCol] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                movingRow++;
                                if (movingRow >= 0 && movingRow < rows && movingCol >= 0 && movingCol < field[movingRow].Length)
                                {
                                    if (field[movingRow][movingCol] == 'T')
                                    {
                                        opponentsTokens++;
                                        field[movingRow][movingCol] = '-';
                                    }
                                }

                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                movingCol++;
                                if (movingRow >= 0 && movingRow < rows && movingCol >= 0 && movingCol < field[movingRow].Length)
                                {
                                    if (field[movingRow][movingCol] == 'T')
                                    {
                                        opponentsTokens++;
                                        field[movingRow][movingCol] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                movingCol--;
                                if (movingRow >= 0 && movingRow < rows && movingCol >= 0 && movingCol < field[movingRow].Length)
                                {
                                    if (field[movingRow][movingCol] == 'T')
                                    {
                                        opponentsTokens++;
                                        field[movingRow][movingCol] = '-';
                                    }
                                }
                            }
                        }
                    }
                }
                else if (command == "Gong")
                {
                    break;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(String.Join(" " , field[i]));
            }

            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentsTokens}");
        }
    }
}
