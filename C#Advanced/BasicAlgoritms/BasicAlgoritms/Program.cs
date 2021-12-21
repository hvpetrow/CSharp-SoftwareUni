using System;
using System.Linq;

namespace BasicAlgoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = 0;   
            Console.WriteLine(Sum(numbers, index));
        }

        private static int Sum(int[]numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }

            int sum = numbers[index] + Sum(numbers, index + 1);
            return sum;
        }
    }
}
