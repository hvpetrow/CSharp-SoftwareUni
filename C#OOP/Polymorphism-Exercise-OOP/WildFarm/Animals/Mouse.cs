using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
   public class Mouse : Mammal
    {
        private const double foodModificator = 0.10;

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(string food, int quantity)
        {
            if (food == "Vegetable" || food == "Fruit")
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
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{ Name}, { Weight}, { LivingRegion}, { FoodEaten}]";

        }
    }
}
