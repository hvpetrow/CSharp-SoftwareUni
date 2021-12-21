using System;

namespace Vehicles
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            int carCapacity = int.Parse(carInfo[3]);

            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            int truckCapacity = int.Parse(truckInfo[3]);


            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            int busCapacity = int.Parse(busInfo[3]);


            IDriveable car = new Car(carFuelQuantity,carFuelConsumption,carCapacity);
            IDriveable truck = new Truck(truckFuelQuantity,truckFuelConsumption,truckCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busCapacity);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string vehicle = parts[1];

                if (vehicle== "Truck")
                {
                    if (command == "Drive")
                    {
                        double truckDistance = double.Parse(parts[2]);
                        if (truck.CanDrive(truckDistance))
                        {
                            truck.Drive(truckDistance);
                            Console.WriteLine($"Truck travelled {truckDistance} km");
                        }
                        else
                        {
                            Console.WriteLine($"Car needs refueling"); 
                        }          
                    }
                    else if (command == "Refuel")
                    {
                        double fuel = double.Parse(parts[2]);
                        if (fuel<=0)
                        {
                            Console.WriteLine("Fuel must be a positive number");
                        }

                        truck.Refuel(fuel);
                    }
                }
                else if (vehicle == "Car")
                {
                    if (command == "Drive")
                    {
                        double carDistance = double.Parse(parts[2]);
                        Console.WriteLine(car.Drive(carDistance)); 
                    }
                    else if (command == "Refuel")
                    {
                        double fuel = double.Parse(parts[2]);
                        car.Refuel(fuel);
                    }
                }
                else if (vehicle == "Bus")
                {
                    if (command == "Drive")
                    {
                        double busDistance = double.Parse(parts[2]);
                        Console.WriteLine(bus.Drive(busDistance));
                    }
                    else if (command=="DriveEmpty")
                    {
                        double busDistance = double.Parse(parts[2]);
                        Console.WriteLine(bus.DriveEmpty(busDistance));
                    }
                    else if (command == "Refuel")
                    {
                        double fuel = double.Parse(parts[2]);
                        bus.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");

        }
    }
}
