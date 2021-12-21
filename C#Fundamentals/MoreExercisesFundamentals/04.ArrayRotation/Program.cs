using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToArray();

            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
            int firstElement = arr1[0];

                for (int i =1; i < arr1.Length; i++)
                {
                    arr1[i - 1] = arr1[i];
                }
                arr1[arr1.Length - 1] = firstElement;

            } 
            foreach (var element in arr1)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
