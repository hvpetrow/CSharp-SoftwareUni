using System;
using System.Collections.Generic;

namespace ImplementStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>();
            string[] input = Console.ReadLine().Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < input.Length; i++)
            {
                elements.Add(input[i]);
            }
            Stack<string> stack = new Stack<string>(elements);
            input = Console.ReadLine().Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input[0] == "Push")
                {
                    stack.Push(input[1]);
                }
                else if (input[0] == "Pop")
                {
                    stack.Pop();
                }
                input = Console.ReadLine().Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
