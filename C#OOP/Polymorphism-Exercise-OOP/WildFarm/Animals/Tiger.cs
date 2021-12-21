using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
   public class Tiger:Feline
    {
        private const double foodModificator = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
        }

        public override string ToString()
        {
            return $"{GetType().Name} {base.ToString()}";
        }
    }
}
