using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IDriveable
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; private set; }

        public int TankCapacity { get; private set; }
        public bool CanDrive(double km)
        {
            if (FuelQuantity - (km*FuelQuantity)>=0)
            {
                return true;
            }
            return false;
        }

        public void Drive(double distance)
        {
            FuelQuantity -= distance * FuelConsumption;
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}
