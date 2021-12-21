using System;
using System.Collections.Generic;

namespace SetsandDictionariesAdvanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            foreach (var number in input)
            {
                double n = double.Parse(number);

                if (!dictionary.ContainsKey(n))
                {
                    dictionary.Add(n, 0);
                }

                dictionary[n]++;
            }

            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
