using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
   public class Dog:Mammal
    {
        private const double foodModificator = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
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
            return "Woof!";
        }

        public override string ToString()
        {
           return $"{GetType().Name} [{Name}, { Weight}, { LivingRegion}, { FoodEaten}]";
        }
    }
}
