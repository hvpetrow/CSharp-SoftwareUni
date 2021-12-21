using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Stack<int> clothes = new Stack<int>(input);

            int capacityRack = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 1;

            while (clothes.Count>0)
            {
                int cloth = clothes.Peek();

                sum += cloth;

                if (sum>capacityRack)
                {
                    counter++;
                    sum = cloth;
                }
                else if (sum==capacityRack)
                {
                    counter++;
                    sum = 0;

                    if (clothes.Count-1==0)
                    {
                        counter--;

                    }
                }

                clothes.Pop();

            }

            Console.WriteLine(counter);
        }
    }
}
