using System;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysCount = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[arraysCount][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] lineArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                jaggedArray[i] = new int[lineArray.Length];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = int.Parse(lineArray[j]);
                }
            }

            while (true)
            {       
                    string[] line = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries);
                    string command = line[0];

                if (command == "END")
                {
                    break;
                }

                    int arrNumber = int.Parse(line[1]);
                    int elementNumber = int.Parse(line[2]);
                    int value = int.Parse(line[3]);

                if ((arrNumber>=jaggedArray.Length || arrNumber<0 ) || (elementNumber>= jaggedArray[arrNumber].Length || elementNumber<0 ) )
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (command=="Add")
                {
                jaggedArray[arrNumber][elementNumber] += value;
                }
                else if (command=="Subtract")
                {
                jaggedArray[arrNumber][elementNumber] -= value;
                }               
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
