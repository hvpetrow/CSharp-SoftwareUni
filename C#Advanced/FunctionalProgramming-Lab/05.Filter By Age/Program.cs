using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Filter_By_Age
{
    class Student
    {
        public string Name;

        public int Age;



    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> persons = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var line = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int age = int.Parse(line[1]);

                var person = new Student();

                person.Name = name;
                person.Age = age;

                persons.Add(person);

            }

            var filterName = Console.ReadLine();
            var ageToCompareWith = int.Parse(Console.ReadLine());

            Func<Student, bool> func = p => true;

            if (filterName == "younger")
            {
                func = p => p.Age <= ageToCompareWith;
            }
            else if (filterName == "older")
            {
                func = p => p.Age >= ageToCompareWith;
            }
            else if (filterName == "exact")
            {
                func = p => p.Age == ageToCompareWith;
            }

            var filteredPeople = persons.Where(func);
            var printName = Console.ReadLine();

            Func<Student, string> filter2 = p => p.Name + " - " + p.Age;

            if (printName == "name age")
            {
                filter2 = p => p.Name + " - " + p.Age;
            }
            else if (printName == "name")
            {
                filter2 = p => p.Name;
            }
            else if (printName == "age")
            {
                filter2 = p => p.Age.ToString();
            }

            var personAsString = filteredPeople.Select(filter2);

            foreach (var str in personAsString)
            {
                Console.WriteLine(str);
            }
        }
    }
}
