using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double foodModificator = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Eat(string food, int quantity)
        {
                Weight += quantity * foodModificator;
                FoodEaten += quantity;         
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return $"{GetType().Name} {base.ToString()}";
        }
    }
}
