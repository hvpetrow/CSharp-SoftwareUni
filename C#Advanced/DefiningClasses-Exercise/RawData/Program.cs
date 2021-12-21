using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsCollection = new List<Car>();
           
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = parts[0];
                int engineSpeed = int.Parse(parts[1]);
                int enginePower = int.Parse(parts[2]);
                int cargoWeight = int.Parse(parts[3]);
                string cargoType = parts[4];

                List<Tire> tiresCollection = new List<Tire>();

                for (int index = 5; index < parts.Length; index+=2)
                {
                    double tirePressure = double.Parse(parts[index]);
                    int tireAge = int.Parse(parts[index+1]);
                    Tire tire = new Tire(tireAge , tirePressure);
                    tiresCollection.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Car car = new Car(model, cargo, engine, tiresCollection);
                

                carsCollection.Add(car);
            }

            string command = Console.ReadLine();
            var filteredCarCollection = new List<Car>();

            if (command == "fragile")
            {
                filteredCarCollection = carsCollection.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Pressure < 1)).ToList(); ;
            }
            else
            {
                filteredCarCollection = carsCollection.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power>250).ToList();
            }

            foreach (var item in filteredCarCollection)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
