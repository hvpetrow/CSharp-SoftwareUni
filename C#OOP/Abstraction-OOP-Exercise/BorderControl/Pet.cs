using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBirthdayable
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get;}
        public string Birthday { get; }
    }
}
