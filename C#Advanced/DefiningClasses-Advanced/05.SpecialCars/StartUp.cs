using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecialCars
{
    class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelConsumption = 10;
            FuelQuantity = 200;
        }

        public Car(string make, string model)
        {
            Make = make;

            Model = model;
        }
        public Car(string make, string model, int year) : this(make, model)
        {
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tire) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tire = tire;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }

        public Tire[] Tire { get; set; }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"HorsePowers: {Engine.HorsePower}");
            sb.AppendLine($"FuelQuantity: {FuelQuantity:F1}");
            return sb.ToString();
        }

        public void Drive(double distance)
        {
            var consumption = distance * FuelConsumption / 100.0;
            if (consumption <= FuelQuantity)
            {
                FuelQuantity -= consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }


        }
    }

    class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }

    }

    class Tire
    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }

    }
    public static class StartUp
    {
        static void Main(string[] args)
        {
            var listOfTires = new List<Tire[]>();
            var listOftEngines = new List<Engine>();
            var listOfCars = new List<Car>();
            
            string commandForTires;
            while ((commandForTires = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = commandForTires.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var tempListOfTires = new List<Tire>();
                for (int i = 0; i < 8; i += 2)
                {
                    int year = int.Parse(tireInfo[i]);
                    double pressure = double.Parse(tireInfo[i + 1]);
                    var currentTire = new Tire(year, pressure);
                   
                    tempListOfTires.Add(currentTire);
                }

                var currentArrayOfTires = tempListOfTires.ToArray();
                listOfTires.Add(currentArrayOfTires);
            }

            string commandForEngine;
            while ((commandForEngine = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = commandForEngine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int hoursePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);
                var newEngine = new Engine(hoursePower, cubicCapacity);
                listOftEngines.Add(newEngine);
            }

            string commandForCar;
            while ((commandForCar = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = commandForCar.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                if (engineIndex >= 0 && engineIndex < listOftEngines.Count && tiresIndex >= 0 && tiresIndex < listOfTires.Count)
                {
                    Engine engine = listOftEngines[engineIndex];
                    Tire[] tires = listOfTires[tiresIndex];

                    var newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                    listOfCars.Add(newCar);
                }
            }

            var filterCars = listOfCars.Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330).ToList();
            if (filterCars.Any())
            {
                foreach (var car in filterCars)
                {
                    double sumOfPressure = 0;
                    foreach (var tire in car.Tire)
                    {
                        sumOfPressure += tire.Pressure;
                    }

                    if (sumOfPressure >= 9 && sumOfPressure <= 10)
                    {
                        car.Drive(20);
                        Console.WriteLine(car.WhoAmI());
                    }
                }
            }
        }
    }
}


