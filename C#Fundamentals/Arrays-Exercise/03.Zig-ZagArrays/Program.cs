using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] firstArray = new int[number];
            int[] secondArray = new int[number];

            for (int i = 0; i < firstArray.Length; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray()
                    ;

                if (i%2==0)
                {
                    firstArray[i] = input[0];
                    secondArray[i] = input[1];

                }
                else
                {
                    firstArray[i] = input[1];
                    secondArray[i] = input[0];
                }
            }
            foreach (var items in firstArray)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine();
            foreach (var items2 in secondArray)
            {
                Console.Write($"{items2} ");
            }


        }
    }
}
