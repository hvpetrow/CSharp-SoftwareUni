using System;
using System.Collections.Generic;
using System.Linq;
namespace List.Exercises._04.ListOperations
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
                if (input == "End")
                {
                    break;

                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);

                    numbers.Add(number);

                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    numbers.Insert(index, number);


                }

                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                    numbers.RemoveAt(index);

                    }

                }
                else if (command == "Shift")
                {
                    string line = tokens[1];
                    int count = int.Parse(tokens[2]);

                    for (int i = 0; i < count; i++)
                    {
                        if (line == "left")
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                        else if (line == "right")
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
