using System;
using System.Linq; 

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line  = Console.ReadLine();
            string[] arr = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal[] iArray = new decimal[arr.Length];

            for (int i = 0; i <iArray.Length ; i++)
            {
                iArray[i] = decimal.Parse(arr[i]);

            }
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine($"{iArray[i]} => {Math.Round(iArray[i],MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
