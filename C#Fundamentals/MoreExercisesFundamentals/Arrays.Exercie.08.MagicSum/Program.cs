using System;
using System.Linq;

namespace Arrays.Exercie._08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());




            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    int nextNumber = arr[j];
                    int sum = currentNumber + nextNumber;
                    if (sum==magicNumber)
                    {
                        Console.Write($"{currentNumber} { nextNumber}");
                        Console.WriteLine();
                        break;
                    }
                    
                }
            }



        }
    }
}
