using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> mileageByCar = new Dictionary<string, int>();
            Dictionary<string, int> fuelByCar = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries );
                string car = tokens[0];
                int mileage =int.Parse( tokens[1]);
                int fuel = int.Parse(tokens[2]);

                mileageByCar.Add(car, mileage);
                fuelByCar.Add(car, fuel);

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Stop")
                {
                    break;
                }

                string[] parts = input.Split(" : " , StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string car = parts[1];

                if (command =="Drive")
                {
                    int distance = int.Parse(parts[2]);
                    int fuel = int.Parse(parts[3]);

                    if (fuelByCar[car]>=fuel)
                    {
                        mileageByCar[car] += distance;
                        fuelByCar[car] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                    if (mileageByCar[car] >= 100000)
                    {
                        fuelByCar.Remove(car);
                        mileageByCar.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command=="Refuel")
                {
                    int fuel = int.Parse(parts[2] );
                    int tank =fuelByCar[car];
                    fuelByCar[car] += fuel;
                    
                    if (fuelByCar[car]>75)
                    {
                        fuelByCar[car] = 75;
                        Console.WriteLine($"{car} refueled with {fuelByCar[car]-tank} liters");
                        continue;
                    }

                    Console.WriteLine($"{car} refueled with {fuel} liters");

                }
                else if (command=="Revert")
                {
                    int kilometers = int.Parse(parts[2]);

                    mileageByCar[car] -= kilometers;
                    Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");

                    if (mileageByCar[car]<10000)
                    {
                        mileageByCar[car] = 10000;
                    }


                }
            }

                  Dictionary<string, int> sorted = mileageByCar
                .OrderByDescending(x => x.Value).ThenBy(n => n.Key)
                .ToDictionary(n => n.Key, x => x.Value);
            foreach (var kvp in sorted)
            {
                string car = kvp.Key;
                int mileage = kvp.Value;
                int fuel = fuelByCar[car];

            Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");

            }
        }
    }
}
