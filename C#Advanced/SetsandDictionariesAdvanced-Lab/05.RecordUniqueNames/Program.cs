using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n ; i++)
            {
                string line = Console.ReadLine();

                set.Add(line);


            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
