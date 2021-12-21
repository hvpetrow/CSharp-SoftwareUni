using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!dictionary.ContainsKey(color))
                {
                    dictionary.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in clothes)
                {
                    if (!dictionary[color].ContainsKey(cloth))
                    {
                        dictionary[color].Add(cloth, 0);
                    }

                    dictionary[color][cloth]++;

                }
            }

            string[] searchingCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = searchingCloth[0];
            string item = searchingCloth[1];

            foreach (var col in dictionary)
            {
                string clothColor = col.Key;

                Console.WriteLine($"{clothColor} clothes:");

                foreach (var cloth in col.Value)
                {
                    string clothName = cloth.Key;
                    int clothCount = cloth.Value;

                    if (type == clothColor && item == clothName)
                    {
                        Console.WriteLine($"* {clothName} - {clothCount} (found!)");
                     
                    }
                    else
                    {
                     Console.WriteLine($"* {clothName} - {clothCount}");

                    }
                }
            }
        }
    }
}
