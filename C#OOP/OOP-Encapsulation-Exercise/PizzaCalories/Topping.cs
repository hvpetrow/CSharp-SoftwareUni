using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private double weight;

        private Dictionary<string, double> toppings = new Dictionary<string, double>
        {
            {"meat" , 1.2 },
            {"veggies" , 0.8 },
            {"cheese" , 1.1 },
            {"sauce" , 0.9 }
        };

        public Topping(string toppingType, double weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }
        
        public string ToppingType // meat, veggies, cheese, or a sauce
        {
            get { return toppingType; }
           private set 
            {
                if (!toppings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value; 
            }
        }

        public double Weight // [1..50] 
        {
            get { return weight; }
           private set 
            {
                if (value < 1 || value >50)
                {
                    throw new ArgumentException($"{toppingType} weight should be in the range[1..50].");
                }
                weight = value; 
            }
        }

        public double Calories
            => 2 * toppings[toppingType] * weight;
    }
}
