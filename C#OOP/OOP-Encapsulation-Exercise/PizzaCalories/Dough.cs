using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const string DoughException = "Invalid type of dough.";
        private const string WeightException = "Dough weight should be in the range [1..200].";
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private Dictionary<string, double> flours = new Dictionary<string, double>
        {
            {"white" , 1.5 },
            {"wholegrain" , 1.0 }
        };
        private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            {"crispy" , 0.9 },
            {"chewy" , 1.1 },
             {"homemade" , 1.0 }
        };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType // white or wholegrain
        {
            get { return flourType; }
            private set
            {
                if (!flours.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(DoughException);
                }
                flourType = value;
            }
        }

        public string BakingTechnique // crispy, chewy or homemade
        {
            get { return bakingTechnique; }
            private set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(DoughException);
                }
                bakingTechnique = value;
            }
        }

        public double Weight // [1..200]
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(WeightException);
                }
                weight = value;
            }
        }

        public double Calories
            => 2 * Weight * flours[flourType.ToLower()] * bakingTechniques[bakingTechnique.ToLower()];
    }
}
