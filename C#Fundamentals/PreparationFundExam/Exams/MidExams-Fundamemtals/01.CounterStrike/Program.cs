using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonBattles = 0;


            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End of battle")
                {
                    break;

                }

                int distance = int.Parse(input);

                if (energy-distance>=0)
                {
                energy -= distance;
                    wonBattles++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
                if (wonBattles%3==0)
                {
                    energy += wonBattles;
                }

            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
