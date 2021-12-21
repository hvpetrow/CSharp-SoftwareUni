using System;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Where(word => word.Length % 2 == 0)
                  .ToList()
                  .ForEach(word => Console.WriteLine(word));
        }
    }
}
