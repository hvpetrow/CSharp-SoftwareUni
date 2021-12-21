using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> foodByAnimals = new Dictionary<string, int>();
            Dictionary<string, string> animalByAreas = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "EndDay")
                {
                    break;
                }

                string[] parts = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string animal = parts[1];

                if (command == "Add")
                {
                    int food = int.Parse(parts[2]);
                    string area = parts[3];


                    if (!foodByAnimals.ContainsKey(animal))
                    {
                        foodByAnimals.Add(animal, food);
                        animalByAreas.Add(animal, area);

                    }
                    else
                    {
                        foodByAnimals[animal] += food;
                    }
                }
                else if (command == "Feed")
                {
                    int food = int.Parse(parts[2]);

                    if (foodByAnimals.ContainsKey(animal))
                    {
                        foodByAnimals[animal] -= food;

                        if (foodByAnimals[animal] <= 0)
                        {
                            foodByAnimals.Remove(animal);
                            animalByAreas.Remove(animal);

                            Console.WriteLine($"{animal} was successfully fed");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Dictionary<string, int> sorted = foodByAnimals.OrderByDescending(x => x.Value)
               .ThenBy(n => n.Key)
               .ToDictionary(n => n.Key, x => x.Value);

            Console.WriteLine("Animals:");
            foreach (var animal in sorted)
            {
                string tier = animal.Key;
                int neededFood = animal.Value;

                Console.WriteLine($" {tier} -> {neededFood}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            string area51 = null;
            foreach (var item in animalByAreas)
            {

                string animal = item.Key;
                area51 = item.Value;


            }
            Console.WriteLine($" {area51}: {animalByAreas.Count}");
        }
    }
}
