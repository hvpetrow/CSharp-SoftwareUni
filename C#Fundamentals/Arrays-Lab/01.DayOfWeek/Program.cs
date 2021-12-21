using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[]
                            {
                             "Monday",
                            "Tuesday",
                            "Wednesday",
                            "Thursday",
                            "Friday",
                            "Saturday",
                            "Sunday"
                            };

            if (n>7 || n <=0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine($"{arr[n-1]}");
            }

        }
    }
}
