using System;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while (true)
            {
                var command = Console.ReadLine();
            Func<int, int> func = null;

                if (command=="end")
                {
                    break;
                }

                if (command=="add")
                {
                    func = n => n + 1;
                }
                else if (command=="multiply")
                {
                    func = n => n * 2;
                }
                else if (command == "subtract")
                {
                    func = n => n - 1;
                }

                if (command == "print")
                {
                    Console.WriteLine(String.Join(" ", numbers));

                }
                else
                {
                    numbers = numbers.Select(func).ToArray();
                }
            }
        }
    }
}
