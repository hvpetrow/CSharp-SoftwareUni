using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Price(product, quantity); 

        }
        static void Price(string product , int quantity)

        {
            double price = 0;
            if (product=="water")
            {
                price = 1.00; 

            }
            else if (product=="coffee")
            {
                price = 1.50; 

            }
            else if (product=="coke")
            {
                price = 1.40; 

            }
            else
            {
                price = 2.00;

            }
            double totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:f2}");
        
        }
    }
}
