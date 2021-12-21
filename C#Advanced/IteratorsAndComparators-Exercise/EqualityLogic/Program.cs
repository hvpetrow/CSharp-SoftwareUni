using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedPersons = new SortedSet<Person>();
            HashSet<Person> persons = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                sortedPersons.Add(person);
                persons.Add(person);
            }

            Console.WriteLine(sortedPersons.Count);
            Console.WriteLine(persons.Count);
        }
    }
}
