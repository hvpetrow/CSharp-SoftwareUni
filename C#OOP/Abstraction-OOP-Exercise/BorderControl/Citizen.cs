using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen:IIdentifiable,IBirthdayable , IBuyer
    {
        public Citizen(string name, int age, string id,string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
            Food = 0;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string Birthday { get; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
