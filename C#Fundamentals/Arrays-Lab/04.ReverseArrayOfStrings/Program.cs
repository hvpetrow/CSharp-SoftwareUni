using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
          
            Console.WriteLine($"{string.Join(" ",arr.Reverse())}");
        }
    }
}
