using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
  public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; } // Judge can make a problem !
        //double Travelled distance

       public void CalculateDistance(double amountKm)
        {
            double neededFuel = amountKm * FuelConsumptionPerKilometer;
            if (FuelAmount>=neededFuel)
            {
                FuelAmount -= neededFuel;
                TravelledDistance += amountKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }        
        }

    }
}
