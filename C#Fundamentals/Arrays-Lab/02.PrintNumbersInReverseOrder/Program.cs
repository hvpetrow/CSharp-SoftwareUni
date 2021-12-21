using System;
using System.Linq;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {

            Console.Write($"{arr[i]} ");
            }

        }
    }
}
