using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Exercise07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] numbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)             
                .ToArray();

           

            
            List<string> list = new List<string>();


            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                string[] elements = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                list.AddRange(elements);



            }

            Console.WriteLine(string.Join(" " , list));
        }
    }
}
