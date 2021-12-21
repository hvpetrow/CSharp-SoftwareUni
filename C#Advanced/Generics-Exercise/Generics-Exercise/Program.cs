
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> listOfBoxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                Box<double> newBox = new Box<double>(input);
               
                listOfBoxes.Add(newBox);
            }
            
            double comparisonValue= double.Parse(Console.ReadLine());

            Console.WriteLine(CountGreater(listOfBoxes, comparisonValue));
        }
        static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
      where T : IComparable<T>
        {
            int counter = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
