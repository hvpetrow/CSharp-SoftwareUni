using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Exercise._02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int number = int.Parse(tokens[1]);
                if (command=="Delete")
                {
                    numbers.RemoveAll(n=>n==number);

                }
                else if (command=="Insert")
                {
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);

                }
            }
            Console.WriteLine(string.Join(" " , numbers));
        }
    }
}
