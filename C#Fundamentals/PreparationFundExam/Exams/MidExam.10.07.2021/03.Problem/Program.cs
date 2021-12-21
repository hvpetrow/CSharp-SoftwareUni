using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> newDeck = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Ready")
                {
                    break;
                }
                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command=="Add")
                {
                    string cardName = parts[1];
                    if (deck.Contains(cardName)==false)
                    {
                        Console.WriteLine("Card not found.");
                        continue;
                    }

                    newDeck.Add(cardName);

                }
                else if (command=="Insert")
                {
                    string cardName = parts[1];
                    int index = int.Parse(parts[2]);

                    if (deck.Contains(cardName) == false||(index<0 ||index>deck.Count-1))
                    {
                        Console.WriteLine("Error!");
                        continue;
                    }
                    newDeck.Insert(index, cardName);
                }
                else if (command=="Remove")
                {
                    string cardName = parts[1];

                    if (newDeck.Contains(cardName) == false)
                    {
                        Console.WriteLine("Card not found.");
                    }
                    newDeck.Remove(cardName);
                }
                else if (command=="Swap")
                {
                    string firstCardName = parts[1];
                    string secondCardName = parts[2];
                    int indexOfFirstCard = newDeck.IndexOf(firstCardName);
                    int indexOfSecondCard = newDeck.IndexOf(secondCardName);
                    newDeck[indexOfFirstCard] = secondCardName;
                    newDeck[indexOfSecondCard] = firstCardName;
                }
                else if (command=="Shuffle")
                {
                    newDeck.Reverse();
                    
                }
            }
            Console.WriteLine(String.Join(" " , newDeck));
        }
    }
}
