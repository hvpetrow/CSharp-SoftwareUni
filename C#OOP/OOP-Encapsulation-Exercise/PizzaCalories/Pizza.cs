using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name; 
            private set
            {
                if (value.Length<1 || value.Length> 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public IReadOnlyCollection<Topping> Toppings => toppings;
 
        public Dough Dough { get; private set; }
        public int ToppingsCount => toppings.Count;
        public double TotalCalories()
        {
           double result = Dough.Calories + toppings.Sum(t => t.Calories);
            return result;
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
    }
}
