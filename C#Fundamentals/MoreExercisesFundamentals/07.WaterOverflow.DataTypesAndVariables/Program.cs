using System;

namespace _07.WaterOverflow.DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
               
                if(sum+liters>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += liters;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
