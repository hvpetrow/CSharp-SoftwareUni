using System;

namespace _11.Snowballs.DataTypesandVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double snowballValue = 0;
            double max = double.MinValue;

            int snow = 0;
            int time = 0;
            int quality = 0;

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < n ; i++)
            {
                snow = int.Parse(Console.ReadLine());
                time = int.Parse(Console.ReadLine());
                quality = int.Parse(Console.ReadLine());

                snowballValue = Math.Pow((snow / time) , quality);

                if (snowballValue>max)
                {
                    max = snowballValue;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;

                }

            }


            Console.WriteLine($"{bestSnow} : {bestTime} = {max} ({bestQuality}) ");

        }
    }
}
