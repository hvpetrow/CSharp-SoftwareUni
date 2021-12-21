using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Cat:Feline
    {
        private const double foodModificator = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(string food,int quantity)
        {
            if (food == "Vegetable" || food =="Meat")
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
            return "Meow";
        }

        public override string ToString()
        {
            return $"{GetType().Name} {base.ToString()}";
        }
    }
}
