using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get => name; set
            {
                if (value == string.Empty)
                {
                   throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                price = value;
            }
        }

        public override string ToString()
           => Name;

    }
}
