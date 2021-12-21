using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IDriveable
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public int TankCapacity { get;}

        public void Drive(double distance);
        public void Refuel(double fuel);
        public bool CanDrive(double km);
    }
}
