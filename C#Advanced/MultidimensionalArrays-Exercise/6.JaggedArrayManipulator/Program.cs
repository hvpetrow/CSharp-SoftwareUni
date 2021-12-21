using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[n][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray[i] = new double[numbers.Length];

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = numbers[j];
                }
            }
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] *= 2;
                        jaggedArray[i+1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] /= 2;
                        
                    }
                    for (int k = 0; k < jaggedArray[i+1].Length; k++)
                    {
                        jaggedArray[i+1][k] /= 2;
                    }
                }         
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];

                if (command=="End")
                {
                    break;
                }
                else if (command=="Add")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);

                    if (row<0 || row>jaggedArray.Length-1 || col<0 || col>jaggedArray[row].Length-1)
                    {
                        continue;
                    }
                    jaggedArray[row][col] += value;
                }
                else if (command=="Subtract")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);

                    if (row < 0 || row > jaggedArray.Length - 1 || col < 0 || col > jaggedArray[row].Length - 1)
                    {
                        continue;
                    }
                        jaggedArray[row][col] -= value;
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(String.Join(" " , jaggedArray[i]));
            }
            
        }
    }
}
