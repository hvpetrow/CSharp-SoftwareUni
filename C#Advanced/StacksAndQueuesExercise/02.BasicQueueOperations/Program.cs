using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);


            int n = numbers[0];
            int numbersToPop = numbers[1];
            int xContaining = numbers[2];

          

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }


            if (stack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if (stack.Contains(xContaining))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
