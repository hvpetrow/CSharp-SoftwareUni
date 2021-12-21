using System;
using System.Text;

namespace CarEngineAndTires
{
  public  class Car
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
    }

  public  class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }

    }

  public class Tire
    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }

    }
   public  class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };

            var engine = new Engine(500, 600);

            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

        }
    }
}


