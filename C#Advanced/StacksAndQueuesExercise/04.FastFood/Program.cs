using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {

            int food = int.Parse(Console.ReadLine());

                int [] orders = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            bool flag = true;
            int biggestOrder = queue.Max();

            Console.WriteLine(biggestOrder);

            while (queue.Count!=0)
            {
                int order = queue.Peek();


                if (food >= order)
                {
                    food -= order;
                    queue.Dequeue();
                }
                else
                {
                   flag = false;
                    break;
                }

            }


            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else  if (flag==false)
            {
                Console.WriteLine($"Orders left: {String.Join(" ",queue)}");
            }




        }
    }
}
