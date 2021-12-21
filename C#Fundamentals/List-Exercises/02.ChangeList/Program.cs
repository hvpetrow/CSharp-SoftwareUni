using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
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
                string input = Console.ReadLine();
                if (input== "end")
                {
                    break;
                }
                string[] line = input.Split();
                int currentNumber = int.Parse(line[1]);

                if (line[0]== "Delete")
                {
                    
                    numbers.RemoveAll(n=>n==currentNumber);
                }
                else if (line[0] == "Insert")
                {
                    int currentPosition = int.Parse(line[2]);
                    numbers.Insert(currentPosition , currentNumber);
                }
            }
            Console.WriteLine(String.Join(" " , numbers));






        }
    }
}
