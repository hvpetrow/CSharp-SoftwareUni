using System;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
               .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int initialHealth = 100;
            int initialBitcoins = 0;
            int counter = 0;
            int health = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int value = int.Parse(tokens[1]);
                counter++;
                if (command == "potion")
                {
                    if (initialHealth + value <= 100)
                    {
                        initialHealth += value;
                        Console.WriteLine($"You healed for {value} hp.");
                    }
                    else
                    {
                        health = 100 - initialHealth;
                        initialHealth = 100;
                        Console.WriteLine($"You healed for {health} hp.");

                    }
                    Console.WriteLine($"Current health: {initialHealth} hp.");

                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {value} bitcoins.");
                    initialBitcoins += value;
                }
                else
                {
                    if (initialHealth > 0)
                    {
                        initialHealth -= value;
                        if (initialHealth>0)
                        {
                        Console.WriteLine($"You slayed {command}.");

                        }
                    }
                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {counter}");
                        return;
                    }
                }
            }
            if (counter == input.Length)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }

        }
    }
}
