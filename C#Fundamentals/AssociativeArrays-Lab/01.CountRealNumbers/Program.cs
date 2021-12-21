using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();


            SortedDictionary<double, int> counters = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (counters.ContainsKey(item))
                {
                    counters[item]++;
                }
                else
                {
                    counters.Add(item, 1);
                }
            }

            foreach (var number in counters)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }


        }
    }
}
