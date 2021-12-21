using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolStations = new Queue<int[]>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] parts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolStations.Enqueue(parts);

            }

            int index = 0;

            while (true)
            {

                int totalFuel = 0;

                foreach (var petrolStation in petrolStations)
                {
                    int fuel = petrolStation[0];
                    int distance = petrolStation[1];
                    totalFuel += fuel - distance;

                    if (totalFuel<0)
                    {
                        petrolStations.Enqueue(petrolStations.Dequeue());
                        index++;
                        break;

                    }
                }
                if (totalFuel>=0)
                {
                    break;
                }
            }
        Console.WriteLine(index);
        }
    }
}
