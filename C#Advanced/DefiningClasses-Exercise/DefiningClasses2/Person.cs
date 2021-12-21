using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
  public  class Person
    {
        public Person()
        {
            Name = "no name";
            Age = 1;
        }
        public Person(int age)
            :this()
        {
            Age = age;
        }
        public Person(int age , string name) :this(age)
        {
            Name = name;
        }

        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

    }
}
