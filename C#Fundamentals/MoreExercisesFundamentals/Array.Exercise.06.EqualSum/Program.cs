using System;
using System.Linq;

namespace Array.Exercise._06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int nextSum = 0;
                int previousSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNumber = arr[j];
                    nextSum += nextNumber;

                }
                for (int k = i - 1; k >= 0; k--)
                {
                    int previousNumber = arr[k];
                    previousSum += previousNumber;
                }
                if (previousSum == nextSum)
                {
                    Console.WriteLine(i);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
