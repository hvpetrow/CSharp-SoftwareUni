using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get; }
        public string Country { get; }
        public int Age { get; }

        string IPerson.GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name }";    
        }

        public override string ToString()
        {
            return $"{(this as IPerson).GetName()} {Environment.NewLine}{(this as IResident).GetName()}";
        }
    }
}
