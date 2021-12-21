using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
   public class Owl :Bird
    {
        private const double foodModificator = 0.25;

        public Owl(string name, double weight,double wingSize) : base(name, weight, wingSize)
        {
        }
        public override void Eat(string food, int quantity)
        {
            if (food == "Meat")
            {
                Weight += quantity * foodModificator;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food}!");
            }
        }

        public override string ProduceSound()
        {
            return $"Hoot Hoot";
        }

        public override string ToString()
        {
            return $"{GetType().Name} {base.ToString()}";
        }
    }
}
