using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] line = command.Split();
                if (line.Length == 2)
                {
                    int currentNumber = int.Parse(line[1]);
                    if (line[0] == "Add")
                    {
                        numbers.Add(currentNumber);
                    }
                    else if (line[0] == "Remove")
                    {
                        if (currentNumber > numbers.Count - 1 || currentNumber < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(currentNumber);
                    }
                }
                else
                {
                    if (line[0] == "Shift")
                    {
                        int count = int.Parse(line[2]);

                        if (line[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (line[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastElement = numbers[numbers.Count - 1];
                                numbers.Insert(numbers[0], lastElement);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                    }
                    else if (line[0] == "Insert")
                    {
                        int currentNum = int.Parse(line[1]);
                        int currentIndex = int.Parse(line[2]);
                        if (currentIndex > numbers.Count - 1 || currentIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(currentIndex, currentNum);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
     
    }
}


