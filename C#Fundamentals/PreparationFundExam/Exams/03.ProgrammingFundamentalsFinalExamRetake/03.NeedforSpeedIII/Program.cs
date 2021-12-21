using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.NeedforSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> milesByCar = new Dictionary<string, int>();
            Dictionary<string, int> fuelByCar = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n ; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string car = input[0];
                int miles = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                if (!milesByCar.ContainsKey(car))
                {
                    milesByCar.Add(car, miles);
                    fuelByCar.Add(car, fuel);
                }

                else
                {
                    milesByCar[car] += miles;
                    fuelByCar[car] += miles;
                }

            }

            while (true)
            {
                string commandsInput = Console.ReadLine();

                if (commandsInput=="Stop")
                {
                    break;
                }

                string[] parts = commandsInput.Split(" : ");

                string command = parts[0];
                string car = parts[1];


                if (command=="Drive")
                {
                    int distance = int.Parse(parts[2]);
                    int fuel = int.Parse(parts[3]);

                    if (fuelByCar[car]<fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        milesByCar[car] += distance;
                        fuelByCar[car] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (milesByCar[car]>=100000)
                        {
                            milesByCar.Remove(car);
                            fuelByCar.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                }
                else if (command=="Refuel")
                {
                    int fuel = int.Parse(parts[2]);
                    int oldTankFuel = fuelByCar[car];

                    fuelByCar[car] += fuel;

                    if (fuelByCar[car]>75)
                    {
                        fuelByCar[car] = 75;
                        Console.WriteLine($"{car} refueled with {fuelByCar[car] - oldTankFuel} liters");
                        continue;
                    }
                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if (command=="Revert")
                {
                    int kilometers = int.Parse(parts[2]);
                    milesByCar[car] -= kilometers;
                    Console.WriteLine($"{car} mileage decreased by {kilometers } kilometers");

                    if (milesByCar[car]<10000)
                    {
                        milesByCar[car] = 10000;

                    }
                }
            }

            Dictionary <string, int> sorted = milesByCar.OrderByDescending(x => x.Value)
                .ThenBy(u => u.Key)
                .ToDictionary(u => u.Key, x => x.Value);

            foreach (var car in sorted)
            {
               string name = car.Key;
                int miles = car.Value;
                int fuel = fuelByCar[name];

                Console.WriteLine($"{name} -> Mileage: {miles} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
