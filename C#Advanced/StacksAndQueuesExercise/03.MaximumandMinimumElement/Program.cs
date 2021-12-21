using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = numbers[0];


                if (command == 1)
                {
                int number = numbers[1];
                    stack.Push(number);
                }
                else if (command == 2)
                {
                if (stack.Count==0)
                {
                    continue;
                }
                    stack.Pop();
                }

                if (stack.Count > 0)
                {
                    if (command == 3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (command == 4)
                    {
                        Console.WriteLine(stack.Min());
                    }

                }
            }

            Console.WriteLine(String.Join(", " , stack));
        }
    }
}
