using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListofProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
               products.Add(Console.ReadLine());
            }
            products.Sort();
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                counter++;
                Console.WriteLine($"{counter}.{products[i]}");


            }
        }
    }
}
