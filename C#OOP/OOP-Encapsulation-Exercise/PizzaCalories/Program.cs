using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] doughInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string pizzaName = pizzaInfo[1];
                string doughFlourType = doughInfo[1];
                string bakingTechnique = doughInfo[2];
                double doughWeight = double.Parse(doughInfo[3]);

                Dough dough = new Dough(doughFlourType, bakingTechnique, doughWeight);
                Pizza pizza = new Pizza(pizzaName, dough);

                string toppingType = Console.ReadLine();

                while (toppingType != "END")
                {
                    string[] toppingInfo = toppingType.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string type = toppingInfo[1];
                    double weight = double.Parse(toppingInfo[2]);

                    Topping topping = new Topping(type, weight);
                    pizza.AddTopping(topping);
                    toppingType = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
