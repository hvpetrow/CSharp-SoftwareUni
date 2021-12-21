using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRetakeExam_16December2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<int, string> foods = new Dictionary<int, string>();
            Dictionary<string , int> cookedFoods = new Dictionary<string , int>();

            foods.Add(25, "Bread");
            foods.Add(50, "Cake");
            foods.Add(75, "Pastry");
            foods.Add(100, "Fruit Pie");

            cookedFoods.Add("Bread", 0);
            cookedFoods.Add("Cake", 0);
            cookedFoods.Add("Fruit Pie", 0);
            cookedFoods.Add("Pastry", 0);

            while (liquids.Any() && ingredients.Any())
            {
                int sum = liquids.Peek() + ingredients.Peek();
                if (foods.ContainsKey(sum))
                {
                    string food = foods[sum];
                    cookedFoods[food]++;                
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop() + 3);
                }
            }

            if (cookedFoods.Count == 4 && !cookedFoods.Any(x=>x.Value==0))
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");      
            }
            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {String.Join(", " , liquids) }");
            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {String.Join(", ", ingredients) }");
            }

            foreach (var food in cookedFoods)
            {
                var foodName = food.Key;
                var amount = food.Value;
                Console.WriteLine($"{foodName}: {amount}");
            }
        }
    }
}
