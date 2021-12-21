using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceWithoutTaxes = 0;
            decimal taxes = 0;
            string command = string.Empty;
            decimal price = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command=="special" || command=="regular")
                {
                    break;
                }

                price = decimal.Parse(command);
                if (price<0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                else if (price==0)
                {
                    Console.WriteLine("Invalid order!");
                  

                }
                priceWithoutTaxes += price;
   
            }
            if (price==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
          

            taxes = 0.20M * priceWithoutTaxes;
            decimal totalPrice = priceWithoutTaxes + taxes;
            if (totalPrice==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (command == "special")
            {
                totalPrice *= 0.9M;
              
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
