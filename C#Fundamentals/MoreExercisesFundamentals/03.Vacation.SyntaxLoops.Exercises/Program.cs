using System;

namespace _03.Vacation.SyntaxLoops.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

           double price = 0;
            double discount = 0;
            double totalPrice = 0;


            if (type=="Students")
            {
                if (day =="Friday")
                {
                    price = 8.45;

                }
                else if (day == "Saturday" )
                {
                    price = 9.80; 
                }
                else if (day =="Sunday")
                {
                    price = 10.46;
                }
               

            }

           else if (type=="Business")
            {
                if (day=="Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }

                else if (day == "Sunday")
                {
                    price = 10.46;
                }               
            }           
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }

                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            totalPrice = price * n;


            if (n >= 30 && type == "Students")
            {
                totalPrice = 0.85 * totalPrice;
            }
            else if (n>=100 && type=="Business")
            {
                totalPrice = totalPrice - 10 * price;

            }
            else if (n>=10 && n<=20 && type == "Regular" )
            {
                totalPrice = totalPrice * 0.95;
            }


            Console.WriteLine($"Total price: {totalPrice:f2}");


        }
    }
}
