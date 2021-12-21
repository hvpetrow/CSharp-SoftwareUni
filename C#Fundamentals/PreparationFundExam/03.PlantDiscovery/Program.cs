using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> rarityByPlant = new Dictionary<string, double>();
            Dictionary<string,  List<double>> ratingsByPlant = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->" , StringSplitOptions.RemoveEmptyEntries);
                string plant = input[0];
                double rarity = double.Parse(input[1]);

                if (!rarityByPlant.ContainsKey(plant))
                {
                    rarityByPlant.Add(plant, rarity);
                    ratingsByPlant.Add(plant, new List<double>());

                }
                else
                {
                    rarityByPlant[plant] += rarity;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Exhibition")
                {
                    break;
                }

                string[] parts = input.Split(new char[] { ' ','-', ':' }, StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string plant = parts[1];

                if (command == "Rate")
                {
                    double rating = double.Parse(parts[2]);

                    ratingsByPlant[plant].Add(rating);

                }
                else if (command=="Update")
                {
                    double rarityNew = double.Parse(parts[2]);
                    rarityByPlant[plant] = rarityNew;
                }
                else if (command=="Reset")
                {
                    ratingsByPlant[plant] = new List<double>();

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            Console.WriteLine("Plants for the exhibition:") ;

            Dictionary<string, double> sorted = rarityByPlant.OrderBy(x => x.Value).ToDictionary(n => n.Key, x => x.Value);
            Dictionary<string, List<double>> joinedDictionary = new Dictionary<string, List<double>>();

            foreach (var item in sorted)
            {
                string plant = item.Key;
                double rarity = item.Value;
                double rating = ratingsByPlant[plant].Average();

                joinedDictionary[plant].Add(rarity);
                joinedDictionary[plant].Add(rating);
            }

            Dictionary<string, List<double>> sortedJoinedDictionary = joinedDictionary.OrderBy(x => x.Value).ToDictionary(n => n.Key, x => x.Value);


            foreach (var item in sortedJoinedDictionary)
            {

                Console.WriteLine($"{ plant_name}; Rarity: { rarity}; Rating: { average_rating formatted to the 2nd digit}");
            }
        }
    }
}
