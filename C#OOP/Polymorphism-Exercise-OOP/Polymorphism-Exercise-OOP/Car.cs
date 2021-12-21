using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IDriveable
    {
        private int tankCapacity;

        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; }
        public int TankCapacity
        {
            get => tankCapacity;
            private set
            {
                if (FuelQuantity > value)
                {
                    FuelQuantity = 0;
                }
                tankCapacity = value;
            }
        }

        public void Refuel(double fuel)
        {

            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");

            }
            else if (FuelQuantity + fuel > tankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
        }

        public string Drive(double distance)
        {
            if (FuelQuantity < (FuelConsumption + 0.9) * distance)
            {
                return $"Car needs refueling";
            }
            else
            {
                FuelQuantity -= (FuelConsumption + 0.9) * distance;
                return $"Car travelled {distance} km";
            }
        }
    }
}
