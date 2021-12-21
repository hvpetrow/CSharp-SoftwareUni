using System;
using System.Linq;

namespace _03.RoundingNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(decimal.Parse)
                 .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
