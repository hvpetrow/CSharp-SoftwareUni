using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Exercise._01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToList();

            int limit = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end")
                {
                    break;
                }
                string[] input = line.Split();
                if (input.Length>=2)
                {
                    string command = input[0];
                    int number = int.Parse(input[1]);

                    numbers.Add(number);

                }
                else
                {
                    int number = int.Parse(input[0]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentWagon = numbers[i];

                        if (currentWagon+number<=limit)
                        {
                            numbers[i] += number;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" " , numbers));
        }
    }
}
