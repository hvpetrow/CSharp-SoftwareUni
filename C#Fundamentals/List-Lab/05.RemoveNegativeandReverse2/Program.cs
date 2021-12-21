using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeandReverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)  
                  .ToList();



            numbers.RemoveAll(n => n < 0);
            numbers.Reverse();


            if (numbers.Count<1)
            {
                Console.WriteLine("empty");

            }
            else
            {
                Console.WriteLine(string.Join(" " , numbers));
            }
        }
    }
}
