using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(kids);
           

            while (children.Count>1)
            {
                for (int i = 1; i < n; i++)
                {
                    var kid =children.Dequeue();
                    children.Enqueue(kid);
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
