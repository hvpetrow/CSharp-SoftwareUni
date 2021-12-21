using System;
using System.Linq;

namespace FunctionalProgramming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x=>x);

            Console.WriteLine(String.Join(", " , newList));
        }
    }
}
