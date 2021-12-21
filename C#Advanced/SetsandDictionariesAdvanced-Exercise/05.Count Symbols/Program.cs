using System;
using System.Collections.Generic;

namespace _05.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> counterDictionary = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            foreach (var item in text)
            {
                if (!counterDictionary.ContainsKey(item))
                {
                    counterDictionary.Add(item, 0);
                }
                counterDictionary[item]++;
            }

            foreach (var item in counterDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
