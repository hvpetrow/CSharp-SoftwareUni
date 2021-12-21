using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];


            for (int i = 0; i < n; i++)
            {
                jaggedArray[i] = new int[i + 1];
                jaggedArray[i][0] = 1;
                jaggedArray[i][jaggedArray[i].Length - 1] = 1;

                for (int j = 1; j < jaggedArray[i].Length-1; j++)
                {
                    jaggedArray[i][j] = jaggedArray[i - 1][j-1] + jaggedArray[i - 1][j];
                }
            }

            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(String.Join(" ",jaggedArray[k]));
            }
        }
    }
}
