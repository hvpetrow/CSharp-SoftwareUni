using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Foods;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal animal = null;
            Food food = null;
            string foodType = null;

            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] infoParts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (counter % 2 == 0)
                {
                    string type = infoParts[0];
                    string name = infoParts[1];
                    double weight = double.Parse(infoParts[2]);
                    //Mammal mammal = null;
                    //Feline feline = null;
                    //Bird bird = null;

                    if (type == "Dog")
                    {
                        string livingRegion = infoParts[3];
                        animal = new Dog(name, weight, livingRegion);

                    }
                    else if (type == "Mouse")
                    {
                        string livingRegion = infoParts[3];
                        animal = new Mouse(name, weight, livingRegion);
                    }
                    else if (type == "Cat")
                    {
                        string livingRegion = infoParts[3];
                        string breed = infoParts[4];
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (type == "Tiger")
                    {
                        string livingRegion = infoParts[3];
                        string breed = infoParts[4];
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                    else if (type == "Owl")
                    {
                        double wingSize = double.Parse(infoParts[3]);
                        animal = new Owl(name, weight, wingSize);

                    }
                    else if (type == "Hen")
                    {
                        double wingSize = double.Parse(infoParts[3]);
                        animal = new Hen(name, weight, wingSize);
                    }
                Console.WriteLine(animal.ProduceSound()); 

                }
                else
                {
                    foodType = infoParts[0];
                    int quantity = int.Parse(infoParts[1]);
                    if (foodType == "Fruit")
                    {
                        food = new Fruit(quantity);
                    }
                    else if (foodType=="Meat")
                    {
                        food = new Meat(quantity);
                    }
                    else if (foodType == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                animal.Eat(foodType, quantity);
                animals.Add(animal);
                }

                counter++;
            }

            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }
        }
    }
}
