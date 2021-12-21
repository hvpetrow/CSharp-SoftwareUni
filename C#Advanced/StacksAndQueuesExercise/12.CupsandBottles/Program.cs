using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsandBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToArray();

            int[] bottles = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToArray();

            Stack<int> bottlesStack = new Stack<int>(bottles);
            Queue<int> cupsQueue = new Queue<int>(cupsCapacity);

            bool flag = false;
            bool noBottles = false;
            int wastedWater = 0;
            int currCup = 0;

            while (true)
            {
                if (!cupsQueue.Any())
                {
                    flag = true;
                    break;
                }
                else if (!bottlesStack.Any ())
                {
                    noBottles = true;
                    break;
                }

                int currentBottle = bottlesStack.Peek();

                if (currCup<=0)
                {
                    currCup = cupsQueue.Peek();
                }
                if (currentBottle>=currCup)
                {
                    wastedWater += (currentBottle - currCup);
                    currCup = 0;
                    bottlesStack.Pop();
                    cupsQueue.Dequeue();
                }
                else
                {
                    currCup -= currentBottle;
                    bottlesStack.Pop();
                }
            }
            if (flag==true)
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottlesStack)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (noBottles==true)
            {
                   Console.WriteLine($"Cups: {String.Join(" " , cupsQueue)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
