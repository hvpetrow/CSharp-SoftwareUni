using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dictionary = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var market = line[0];
                if (market == "Revision")
                {
                    break;
                }
                var product = line[1];
                var price = double.Parse(line[2]);

                if (!dictionary.ContainsKey(market))
                {
                    dictionary.Add(market, new Dictionary<string, double>());
                }
                if (!dictionary[market].ContainsKey(product))
                {
                    dictionary[market].Add(product, price);
                }
               
            }

                foreach ( var markt in dictionary)
                {
                    Console.WriteLine($"{markt.Key}->");
                    foreach (var productt in markt.Value)
                    {
                        Console.WriteLine($"Product: {productt.Key}, Price: {productt.Value}");
                    }
                }
        }
    }
}
