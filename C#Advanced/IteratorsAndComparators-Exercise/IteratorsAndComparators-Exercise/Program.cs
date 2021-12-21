using System;
using System.Collections.Generic;

namespace ListyIt
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> commandArgs = new List<string>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < input.Length; i++)
            {
                commandArgs.Add(input[i]);
            }
            var listyIterator = new ListyIterator<string>(commandArgs);

            string command = Console.ReadLine();
            while (command != "END")
            {

                if (command == "Print")
                {
                    listyIterator.Print();
                }

                else if (command == "HasNext")
                {
                    listyIterator.HasNext();
                }
                else if (command == "Move")
                {
                    listyIterator.Move();
                }
                else if (command == "PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}
