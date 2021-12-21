using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rarityByPlants = new Dictionary<string, int>();
            Dictionary<string, List<double>> dictPlantRating = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = line[0];
                int rarity = int.Parse(line[1]);

                if (!rarityByPlants.ContainsKey(plant))
                {
                    rarityByPlants.Add(plant, rarity);
                    dictPlantRating[plant] = new List<double>();
                }
                else
                {
                    rarityByPlants[plant] += rarity;
                }
            }



            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Exhibition")
                {
                    break;
                }

                string[] parts = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string plant = parts[1];


                if (rarityByPlants.ContainsKey(plant) == false)
                {
                    Console.WriteLine("error");
                }
                else
                {

                    if (command == "Rate:")
                    {
                        double rating = double.Parse(parts[2]);

                        dictPlantRating[plant].Add(rating);


                    }
                    else if (command == "Update:")
                    {
                        int newRarity = int.Parse(parts[2]);


                        rarityByPlants[plant] = newRarity;


                    }
                    else if (command == "Reset:")
                    {

                        dictPlantRating[plant] = new List<double>();
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }

            }
            PrintAndSortMetod(rarityByPlants, dictPlantRating);

        }
        private static void PrintAndSortMetod(Dictionary<string, int> dictPlantRarity, Dictionary<string, List<double>> dictPlantRating)
        {
            Console.WriteLine("Plants for the exhibition: ");

            var newsortedDict = new Dictionary<string, List<double>>();
            foreach (var kvp in dictPlantRating.OrderByDescending(x => x.Value.Count > 0 ? x.Value.Average() : 0)) // NB! if(x.Value.Count > 0) x.Value.Average() else 0;
            {
                string plant = kvp.Key;
                double averageRating = kvp.Value.Count > 0 ? kvp.Value.Average() : 0;
                int rarity = dictPlantRarity[plant];
                double rarityDouble = (double)rarity;

                newsortedDict[plant] = new List<double>();
                newsortedDict[plant].Add(rarityDouble);
                newsortedDict[plant].Add(averageRating);
            }

            foreach (var kvp in newsortedDict.OrderByDescending(x => x.Value[0]))
            {
                string plant = kvp.Key;
                double rarity = kvp.Value[0];
                double averageRating = kvp.Value[1];
                Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {averageRating:F2}");
            }
        }
    }
}
