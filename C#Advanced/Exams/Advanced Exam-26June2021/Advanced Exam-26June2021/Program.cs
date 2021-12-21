using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Exam_26June2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputIngredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputFreshness = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> ingredientsValues = new Queue<int>(inputIngredients);
            Stack<int> freshnessLevelValues = new Stack<int>(inputFreshness);
            Dictionary<int,string> dishesLevels = new Dictionary<int,string>();
            dishesLevels.Add(150,"Dipping sauce");
            dishesLevels.Add(250,"Green salad");
            dishesLevels.Add(300,"Chocolate cake");
            dishesLevels.Add(400,"Lobster");
            Dictionary<string, int> preparedDishes = new Dictionary<string, int>();

            while (true)
            {
                if (!ingredientsValues.Any() || !freshnessLevelValues.Any())
                {
                    break;
                }
                var ingredient = ingredientsValues.Peek();
                var freshness = freshnessLevelValues.Peek();
                var totalLevel = ingredient * freshness;
                if (ingredient==0)
                {
                    ingredientsValues.Dequeue();
                    continue;
                }
                if (dishesLevels.ContainsKey(totalLevel))
                {
                    var dish = dishesLevels[totalLevel];
                    if (!preparedDishes.ContainsKey(dish))
                    {
                    preparedDishes.Add(dish, 1);
                    }
                    else
                    {
                        preparedDishes[dish]++;
                    }
                    ingredientsValues.Dequeue();
                    freshnessLevelValues.Pop();
                }
                else
                {
                    freshnessLevelValues.Pop();
                    ingredient += 5;
                    ingredientsValues.Dequeue();
                    ingredientsValues.Enqueue(ingredient);
                }

            }
            if (preparedDishes.Count >=4)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }

            if (ingredientsValues.Any())
            {
                var totalIngredientsValuesSum = ingredientsValues.Sum();
                Console.WriteLine($" Ingredients left: {totalIngredientsValuesSum}");
            }

            var orderedDishes = preparedDishes.OrderBy(x => x.Key).ToDictionary(x=>x.Key , y=>y.Value);

            foreach (var kvp in orderedDishes)
            {
                var dish = kvp.Key;
                var count = kvp.Value;
                Console.WriteLine($" # {dish} --> {count}");
            }
        }
    }
}
