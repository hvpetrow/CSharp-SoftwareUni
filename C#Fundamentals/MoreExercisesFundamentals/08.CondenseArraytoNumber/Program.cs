using System;
using System.Linq;

namespace _08.CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
          
            while (arr1.Length > 1)
            {
                int[] condensed = new int[arr1.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = condensed;
            }
            Console.WriteLine(arr1[0]);
        }
    }
}
