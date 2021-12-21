using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isExisting = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;

                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

                if (index > sequence.Count - 1)
                {
                    if (command=="Add")
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else if (command=="Strike")
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    continue;
                }
                else if (index < 0)
                {
                    if (command == "Add")
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else if (command == "Strike")
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    continue;
                }
                else
                {
                    isExisting = true;
                }
                if (command == "Shoot")
                {
                    sequence[index] -= value;
                    if (sequence[index] <= 0)
                    {
                        sequence.RemoveAt(index);
                    }
                }
                else if (command == "Add")
                {
                    if (isExisting == true)
                    {
                        sequence.Insert(index, value);
                    }
                    else 
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int minRadius = index - value;
                    int maxRadius = index + value;

                    if (maxRadius > sequence.Count - 1 || minRadius < 0)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    else
                    {
                        for (int i = minRadius; i <= maxRadius; i++)
                        {
                            sequence.RemoveAt(minRadius);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("|", sequence));
        }
    }
}
