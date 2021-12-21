using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> dictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];

                decimal grade = decimal.Parse(parts[1]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = new List<decimal>();

                }

                dictionary[name].Add(grade);
                 
            }

            foreach (var student in dictionary)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var item in student.Value)
                {
                    Console.Write($"{item:F2} "); 
                       
                }
                Console.WriteLine($"(avg: { student.Value.Average():F2})");
            }
        }
    }
}
