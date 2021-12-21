using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
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
            string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "RemoveAt")

                {
                    numbers.RemoveAt(int.Parse(tokens[1]));


                }
                else if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);

                    numbers.Insert(indexToInsert , numberToInsert);

                }
            }
            Console.WriteLine(string.Join(" " , numbers));
        }
    }
}
