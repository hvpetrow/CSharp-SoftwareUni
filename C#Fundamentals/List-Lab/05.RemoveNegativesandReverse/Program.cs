using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .Where(n=>n>=0)
                      .ToList();

            
            numbers.Reverse();

            if (numbers.Count<1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" "   , numbers));
            }



        }
    }
}
