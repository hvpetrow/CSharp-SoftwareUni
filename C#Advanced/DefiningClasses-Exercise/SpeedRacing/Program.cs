using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsCollection = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1Km = double.Parse(carInfo[2]);

                Car car = new Car(model,fuelAmount,fuelConsumptionFor1Km);
                carsCollection.Add(model,car);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }

                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = commandInfo[1];
                double travelledKm = double.Parse(commandInfo[2]);

                carsCollection[model].CalculateDistance(travelledKm);

            }

            foreach (var car in carsCollection)
            {
                string model = car.Key;
                double fuelAmount = car.Value.FuelAmount;
                double distanceTravelled = car.Value.TravelledDistance;

                Console.WriteLine($"{model} {fuelAmount:F2} {distanceTravelled}");          
            }
        }
    }
}
