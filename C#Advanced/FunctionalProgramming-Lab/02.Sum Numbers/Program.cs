using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(MyParse);
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }

        private static int MyParse(string numberAsString)
        {
            int number = 0;
            foreach ( var digit in  numberAsString)
            {
                number *= 10;
                number += (digit - '0');

            }

            return number;
        }
    }
}
