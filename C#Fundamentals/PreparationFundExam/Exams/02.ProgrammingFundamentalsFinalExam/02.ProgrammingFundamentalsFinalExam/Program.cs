using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ProgrammingFundamentalsFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

        

            while (true)
            {
                string inpt = Console.ReadLine();

                if (inpt == "Travel")
                {
                    break;

                }

                string[] parts = inpt.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(parts[1]);
                    string substring = parts[2];

                    if (index >= 0 && index < line.Length)
                    {
                        line=line.Insert(index, substring);
                    }

                    Console.WriteLine(line);
                }

                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    

                    if (startIndex >= 0 && endIndex<line.Length)
                    {
                        line =line.Remove(startIndex, endIndex-startIndex+1);

                    }

                    Console.WriteLine(line);
                }
                else if (command == "Switch")
                {
                    string oldString = parts[1];
                    string mergString = parts[2];

                    if(line.Contains(oldString))
                    {
                        line = line.Replace(oldString, mergString);

                    }

                    Console.WriteLine(line);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {line}");
        }
    }
}
