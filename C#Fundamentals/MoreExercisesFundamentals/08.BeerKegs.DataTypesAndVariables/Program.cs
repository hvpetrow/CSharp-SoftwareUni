using System;

namespace _08.BeerKegs.DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double sum = 0;
            double max = double.MinValue;
            string biggestKeg = string.Empty;


            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                sum = Math.PI * Math.Pow(radius, 2) * height;


                if (sum>max)
                {
                    max = sum;
                    biggestKeg = model;

                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
