using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueuesExercise
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

            Stack<int> stack = new Stack<int>(input);

            int nPushed = numbers[0];
            int sPoppedd = numbers[1];
            int xSearched = numbers[2];

            for (int i = 0; i < sPoppedd; i++)
            {
                stack.Pop();
            }

            int min = int.MaxValue;

            if (stack.Contains(xSearched))
            {
                Console.WriteLine("true");
            }
            else
            {
                foreach (var number in stack)
                {
                  if (min>number)
                  {
                        min = number;
                  }

                }
            }
            Console.WriteLine(min);




        }
    }
}
