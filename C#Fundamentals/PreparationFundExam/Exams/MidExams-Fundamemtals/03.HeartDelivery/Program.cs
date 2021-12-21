using System;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int decreasedHearts = 2;
            int index = 0;
            int lastIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Love!")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int length = int.Parse(tokens[1]);
                    index += length;
                    if (index>field.Length-1)
                    {
                        index = 0;

                    }
                else if (index<0)
                {
                    continue;
                }
                int houseHearts = field[index];
                if (houseHearts==0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                }
                if (houseHearts-decreasedHearts==0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }
                if (houseHearts-decreasedHearts<0)
                {
                    continue;
                }
                    field[index] -= decreasedHearts ;
                lastIndex = index;
            }
            Console.WriteLine($"Cupid's last position was {lastIndex}.");
            int failedHouses = 0;
            bool isFailed = false;
            for (int i = 0; i < field.Length; i++)
            {
                int currentElement = field[i];
                if (currentElement!=0)
                {
                    failedHouses++;
                    isFailed = true;
                }
            }
            if (isFailed == true)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
            
        }
    }
}
