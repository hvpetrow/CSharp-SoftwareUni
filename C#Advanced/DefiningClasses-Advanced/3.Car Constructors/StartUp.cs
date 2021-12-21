using System;
using System.Text;

namespace CarConstructors
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

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"Fuel: {FuelQuantity:F2}L");

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
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity =double.Parse(Console.ReadLine());
            double fuelConsumption=double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make,model,year);
            Car thirdCar = new Car(make,model,year,fuelQuantity,fuelConsumption);





        }
    }
}

