using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(arr);

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input=="end")
                {
                    break;
                }

                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command=="add")
                {
                    for (int i =1 ; i <parts.Length ; i++)
                    {
                        stack.Push(int.Parse(parts[i])); 
                    }
                }
                else if (command== "remove")
                {
                    int countToRemove = int.Parse(parts[1]);

                    if (stack.Count< countToRemove)
                    {
                        continue;
                    }
                    for (int i = 0; i < countToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}") ;
        }
    }
}
