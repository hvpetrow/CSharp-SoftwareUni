using System;
using System.Linq;

namespace PregovorUprajneniqFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int indexDiff = 0;
            int sum = 0;
            bool areEqual = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNumber1 = arr1[i];
                int currentNumber2 = arr2[i];
                if (currentNumber1!=currentNumber2)
                {
                    areEqual = false;
                    indexDiff = i;
                    break;
                }
                else
                {
                    sum += currentNumber1;
                }
            }
            if (!areEqual)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexDiff} index");
            }
            else
            {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }
        }
    }
}
