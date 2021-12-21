using System;
using System.Linq; 


namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int counter = 0 ;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int currentNumber2 = arr2[i];
                counter++;
                if (currentNumber==currentNumber2)
                {
                    sum += currentNumber;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {counter-1} index");
                    return; 
                }

            }
            Console.WriteLine($"Arrays are identical. Sum: { sum}");



        }      
       }
}
