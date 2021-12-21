using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> foodByAnimals = new Dictionary<string, int>();
            Dictionary<string, List<string>> areasByAnimal = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input== "EndDay")
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
                        areasByAnimal[animal]= new List<string>();
                        areasByAnimal[animal].Add(area);

                    }
                    else
                    {
                        foodByAnimals[animal] += food;
                    }
                }
                else if (command=="Feed")
                {
                    int food = int.Parse(parts[2]);

                    if (foodByAnimals.ContainsKey(animal))
                    {
                        foodByAnimals[animal] -= food;

                        if (foodByAnimals[animal]<=0)
                        {
                            foodByAnimals.Remove(animal);
                            areasByAnimal.Remove(animal);

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


            foreach (var animal in sorted)
            {
                string tier = animal.Key;

                foreach (var item in areasByAnimal)
            {
                    for (int i = 0; i < areasByAnimal.Count; i++)
                    {
                    string area = item.Value[i];

                Console.WriteLine($" {area}: {areasByAnimal.Count}");
                    }




            }

            }
        }
    }
}
