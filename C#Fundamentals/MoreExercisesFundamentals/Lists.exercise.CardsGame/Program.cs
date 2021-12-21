using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists.exercise.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
         .ToList();

            List<int> secondHand = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
         .ToList();

            while (firstHand.Count!=0 && secondHand.Count!=0)
            {
                 int firstPlayerCard = firstHand[0];
                 int secondPlayerCard = secondHand[0];

                if (firstPlayerCard>secondPlayerCard)
                {
                    firstHand.Add(firstPlayerCard);
                    firstHand.Add(secondPlayerCard);
                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                }
                else if(secondPlayerCard>firstPlayerCard)
                {
                    secondHand.Add(secondPlayerCard);
                    secondHand.Add(firstPlayerCard);
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
               else if (secondPlayerCard==firstPlayerCard)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }

            }
            if (firstHand.Count==0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
            else if (secondHand.Count==0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");

            }
        }
    }
}
