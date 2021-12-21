using System;
using System.Collections.Generic;

namespace SetsandDictionariesAdvanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();

                hashSet.Add(user);



            }

            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
