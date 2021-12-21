using System;
using System.Text;

namespace CarExtension
{
  public  class Car
    {
        public string Make { get; set; }

        public string Model{ get; set; }

        public int Year{ get; set; }

        public double FuelQuantity{ get; set; }

        public double FuelConsumption{ get; set; }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( $"Make: {Make}");
            sb.AppendLine( $"Model: {Model}");
            sb.AppendLine( $"Year: {Year}");
            sb.AppendLine( $"Fuel: {FuelQuantity:F2}L");

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
            Car car1 = new Car();
            car1.Make = "VW";
            car1.Model = "MK3";
            car1.Year = 1992;
            car1.FuelQuantity = 200;
            car1.FuelConsumption = 200;
            car1.Drive(2000);
            Console.WriteLine(car1.WhoAmI());


        }
    }
}
