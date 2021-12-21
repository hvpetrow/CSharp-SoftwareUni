using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> enginesCollection = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                Engine engine = new Engine();

                if (engineInfo.Length == 3)
                {
                    if (char.IsDigit(engineInfo[2][0]))
                    {
                        int displacement = int.Parse(engineInfo[2]);
                        engine = new Engine(engineModel, power, displacement);

                    }
                    else
                    {
                        string efficiency = engineInfo[2];
                        engine = new Engine(engineModel, power, efficiency);
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engine = new Engine(engineModel, power, displacement, efficiency);
                }
                else
                {
                    engine = new Engine(engineModel, power);

                }
                //"{model} {power} {displacement} {efficiency}"
                enginesCollection.Add(engineModel, engine);

            }

            int m = int.Parse(Console.ReadLine());

            List<Car> carsList = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                string carEngine = carInfo[1];
                Engine engine = enginesCollection[carEngine];

                if (carInfo.Length == 3)
                {
                    if (char.IsDigit(carInfo[2][0]))
                    {
                        int carWeight = int.Parse(carInfo[2]);
                        Car car = new Car(carModel, engine, carWeight);
                        carsList.Add(car);

                    }
                    else
                    {
                        string carColor = carInfo[2];
                        Car car = new Car(carModel, engine, carColor);
                        carsList.Add(car);
                    }
                }
                else if (carInfo.Length == 4)
                {
                    int carWeight = int.Parse(carInfo[2]);
                    string carColor = carInfo[3];

                    Car car = new Car(carModel, engine, carWeight, carColor);
                    carsList.Add(car);
                }
                else
                {
                    Car car = new Car(carModel, engine);
                    carsList.Add(car);
                }
            }

            foreach (var car in carsList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
