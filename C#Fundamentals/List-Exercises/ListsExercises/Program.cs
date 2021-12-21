using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int limit = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;

                }
                string[] line = command.Split();
                if (line.Length==2)
                {
                int currentNumber = int.Parse(line[1]);

                    numbers.Add(currentNumber);
                }
                else
                {
                    int currentNumber = int.Parse(line[0]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentWagon = numbers[i];
                        if (currentWagon + currentNumber<=limit)
                        {
                            numbers[i] += currentNumber;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" " , numbers));

        }
    }
}
