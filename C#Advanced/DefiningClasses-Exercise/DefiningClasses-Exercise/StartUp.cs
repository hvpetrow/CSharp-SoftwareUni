using System;
using System.Linq;

namespace DefiningClasses
{
   
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            var filtered = family.GetPeople();

            foreach (var member in filtered)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }

           
        }
    }
}
