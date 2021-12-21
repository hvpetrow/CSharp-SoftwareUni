using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Lab._07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            bool change = false; 

            int sum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int number = int.Parse(tokens[1]);
                if (command == "Add")
                {
                    numbers.Add(number);
                    change = true;
                    break;
                }
                else if (command == "Remove")
                {
                    numbers.Remove(number);
                    change = true;
                    break;
                }
                else if (command == "RemoveAt")
                {
                    numbers.RemoveAt(number);
                    change = true;
                    break;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);
                    change = true;
                    break;
                }
                else if (command == "Contains")
                {
                    number = int.Parse(tokens[1]);
                  bool isContained =  numbers.Contains(number);
                    if (isContained)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command=="PrintEven")
                {
                    List<int> evenNumbers = new List<int>();
                    evenNumbers.AddRange(numbers.Where(x => x % 2 == 0));
                    Console.WriteLine(string.Join(" " , evenNumbers));

                }
                else if (command=="PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();

                    oddNumbers.AddRange(numbers.Where(x => x % 2 != 0));

                    Console.WriteLine(string.Join(" ", oddNumbers));

                }
                else if (command=="GetSum")
                {
                    foreach (var item in numbers)
                    {
                        sum += item;
                    }
                        Console.WriteLine(sum);
                }
                else if (command=="Filter")
                {
                    string condition = tokens[1];
                    number = int.Parse(tokens[2]);
                    List<int> conditionsNumber = new List<int>();
                    if (condition==">")
                    {
                     conditionsNumber.AddRange(numbers.Where(n => n > number));

                    }
                    else if (condition==">=")
                    {
                        conditionsNumber.AddRange(numbers.Where(n => n >= number));

                    }
                    else if (condition=="<")
                    {
                        conditionsNumber.AddRange(numbers.Where(n => n < number));

                    }
                    else if (condition=="<=")
                    {
                        conditionsNumber.AddRange(numbers.Where(n => n <= number));

                    }

                 Console.WriteLine(string.Join(" ", conditionsNumber));

                }
            }
                if (change == true)
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
        }
    }
}
