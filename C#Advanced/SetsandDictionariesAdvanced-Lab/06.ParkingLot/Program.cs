using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="END")
                {
                    break;
                }

                string[] line = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                string car = line[1];

                if (command=="IN")
                {
                    hashSet.Add(car);
                }
                else if (command=="OUT")
                {
                    hashSet.Remove(car);
                }
            }

            if (hashSet.Any())
            {
                foreach (var item in hashSet)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
