using System;
using System.Linq;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            // Func<int[], int> smallestNumber = n => n.Min();   
            Func<int[], int> smallestNumber = arr =>
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }

                return min;
            };
                Console.WriteLine(smallestNumber(printer));
            }
    }
}
