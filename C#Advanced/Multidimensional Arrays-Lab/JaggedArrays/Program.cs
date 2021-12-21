using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int arrays = 0; arrays < jaggedArray.Length; arrays++)
            {

                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                jaggedArray[arrays] = new int[line.Length];

                for (int elements = 0; elements < jaggedArray[arrays].Length; elements++)
                {
                    jaggedArray[arrays][elements] = int.Parse(line[elements]);
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
