using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> populationByCity = new Dictionary<string, int>();
            Dictionary<string, int> goldByCity = new Dictionary<string, int>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Sail")
                {
                    break;

                }

                string[] tokens = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string city = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (!populationByCity.ContainsKey(city))
                {
                    populationByCity.Add(city, population);
                    goldByCity.Add(city, gold);
                }
                else
                {
                    populationByCity[city] += population;
                    goldByCity[city] += gold;
                }
            }

            while (true)
            {
                string secondInput = Console.ReadLine();

                if (secondInput=="End")
                {
                    break;
                }

                string[] parts = secondInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                    string city = parts[1];
              

                if (command=="Plunder")
                {
                    int population = int.Parse(parts[2]);
                    int gold = int.Parse(parts[3]);

                    populationByCity[city] -= population;
                    goldByCity[city] -= gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (goldByCity[city]<=0 || populationByCity[city] <=0 )
                    {
                        populationByCity.Remove(city);
                        goldByCity.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }

                }
                else if (command=="Prosper")
                {
                    int gold = int.Parse(parts[2]);

                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }


                    goldByCity[city] += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {goldByCity[city]} gold.");                
                }
            }

            if (goldByCity.Count>0)
            {
                Dictionary<string, int> sortedDict = goldByCity.OrderByDescending(x => x.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, x => x.Value);
                    Console.WriteLine($"Ahoy, Captain! There are {goldByCity.Count} wealthy settlements to go to:");

                foreach (var town in sortedDict)
                {
                    string city = town.Key;
                    int gold = town.Value;
                    int population = populationByCity[city];

                    Console.WriteLine($"{city} -> Population: { population} citizens, Gold: {gold} kg");

                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
