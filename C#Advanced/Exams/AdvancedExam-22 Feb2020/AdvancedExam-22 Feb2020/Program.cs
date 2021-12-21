using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam_22_Feb2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queueBox = new Queue<int>(firstBox);
            Stack<int> stackBox = new Stack<int>(secondBox);
            bool queueEmptityFlag = false;
            int claimedItemsSum = 0;

            while (true)
            {
                if (!queueBox.Any())
                {
                    queueEmptityFlag = true;
                    break;
                }
                if (!stackBox.Any())
                {
                    break;
                }
                int currentSum = stackBox.Peek() + queueBox.Peek();
                if (currentSum%2==0)
                {
                    claimedItemsSum += currentSum;
                    stackBox.Pop();
                    queueBox.Dequeue();
                }
                else
                {
                   queueBox.Enqueue(stackBox.Pop());
                }
            }

            if (queueEmptityFlag==true)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItemsSum>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItemsSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItemsSum}");
            }
        }
    }
}
