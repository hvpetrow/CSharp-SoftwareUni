using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : IDriveable
    {

        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            TankCapacity = tankCapacity;
            if (fuelQuantity<=TankCapacity)
            {
                FuelQuantity = fuelQuantity;
            }
            else
            {
                FuelQuantity = 0;
            }
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get;private set; }

        public int TankCapacity { get;private set; }


        public string Drive(double distance)
        {
            if (FuelQuantity < (FuelConsumption + 1.4) * distance)
            {
                return $"Bus needs refueling";
            }
            else
            {
                FuelQuantity -= (FuelConsumption + 1.4) * distance;
                return $"Bus travelled {distance} km";
            }
        }
        public string DriveEmpty(double distance)
        {
            if (FuelQuantity < FuelConsumption * distance)
            {
                return $"Bus needs refueling";
            }
            else
            {
                FuelQuantity -= FuelConsumption * distance;
                return $"Bus travelled {distance} km";
            }
        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                return;
            }
            
                FuelQuantity += fuel;          
        }
    }
}
