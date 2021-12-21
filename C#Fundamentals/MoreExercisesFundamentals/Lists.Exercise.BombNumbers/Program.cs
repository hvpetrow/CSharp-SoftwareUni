using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Exercise.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
          .ToList();

            int[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
         

            int bombIndex = 0;
       
            int number = coordinates[0];
            int power = coordinates[1];
          


            int limit = numbers.Count - 1;
            while (true)
            {
                int index = numbers.IndexOf(number);
                if (index<0)
                {
                    break;
                }
                int startIndex = index - power;
                if (startIndex<0)
                {
                    startIndex = 0;
                }

                int endIndex = index + power;
                if (endIndex>numbers.Count-startIndex)
                {
                    endIndex = numbers.Count - startIndex;
                }
                numbers.RemoveRange(startIndex, endIndex);
            }
          

            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }

            Console.WriteLine(sum);
                
        }
    }
}
