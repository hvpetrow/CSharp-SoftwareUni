using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int n = int.Parse(Console.ReadLine());
            int passedCarsCount = 0;

            while (true)
            {
                string car = Console.ReadLine();

                if (car=="end")
                {
                    break;
                }
                else if (car=="green")
                {
                    if (cars.Count < n)
                    {
                        n = cars.Count;
                    }
                    for (int i = 0; i < n; i++)
                    {
                       
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCarsCount++;
                    }

                    
                }
                else
                {
                    cars.Enqueue(car);
                }
            }

            Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");

        }
    }
}
