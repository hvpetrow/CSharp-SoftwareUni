using System;
using System.Linq;

namespace FunctionalProgramming_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {         
            Action<string> print = name => Console.WriteLine(name);
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(print);
        }
    }
}
