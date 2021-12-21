using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Lab._01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < number.Count; i++)
            {
                if (i + 1 > number.Count - 1)
                {
                    break;
                }
                double nextNumber = number[i + 1];

                if (number[i] == nextNumber)
                {
                    number[i] += nextNumber;
                    number.RemoveAt(i+1);
                    i= -1;
                }
                
            }
            Console.WriteLine(string.Join(" " , number));
        }
    }
}
