using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long n = input[0];
            long m = input[1];

            HashSet<long> firstHashSet = new HashSet<long>();
           
            HashSet<long> uniqueHashSet = new HashSet<long>();

            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                firstHashSet.Add(number);
            }

            for (int j = 0; j < m; j++)
            {
                long number = long.Parse(Console.ReadLine());
              
                if (firstHashSet.Contains(number))
                {
                    uniqueHashSet.Add(number);
                }
            }

            uniqueHashSet.IntersectWith(firstHashSet);

            Console.WriteLine(String.Join(" " , uniqueHashSet));

         

        }
    }
}
