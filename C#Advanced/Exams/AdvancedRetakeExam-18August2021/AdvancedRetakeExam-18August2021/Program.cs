using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRetakeExam_18August2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] guestEatingCapacity = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //sequence of integers – each indicating the eating capacity of a single guest//
            int[] inputPlates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //sequence of integers - the plates//

            Queue<int> guests = new Queue<int>(guestEatingCapacity);
            Stack<int> plates = new Stack<int>(inputPlates);
            int wastedFoodSum = 0;
            int guest = guests.Peek();

            while (plates.Count != 0 && guests.Count != 0)
            {
                int plate = plates.Peek();
                if (plate >= guest)
                {
                    wastedFoodSum += plate - guest;
                    guests.Dequeue();
                    plates.Pop();

                    if (guests.Any())
                    {
                        guest = guests.Peek();
                    }
                }
                else
                {
                    guest -= plate;
                    plates.Pop();
                }
            }

            if (plates.Count == 0)
            {
                Console.WriteLine($"Guests: {String.Join(" ", guests)}");
                Console.WriteLine($"Wasted grams of food: {wastedFoodSum}");
            }
            else
            {
                Console.WriteLine($"Plates: {String.Join(" ", plates)}");
                Console.WriteLine($"Wasted grams of food: {wastedFoodSum}");
            }
        }
    }
}
