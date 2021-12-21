using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> foods = new Dictionary<string, IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                IBuyer buyer = null;

                if (input.Length == 4)
                {
                    string id = input[2];
                    string birthday = input[3];
                    buyer = new Citizen(name, age, id, birthday);
                }
                else if (input.Length == 3)
                {
                    string group = input[2];
                    buyer = new Rebel(name, age, group);
                }

                foods.Add(name, buyer);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (foods.ContainsKey(input))
                {
                    foods[input].BuyFood();
                }
            }

            Console.WriteLine(foods.Sum(x=> x.Value.Food));
        }
    }
}
