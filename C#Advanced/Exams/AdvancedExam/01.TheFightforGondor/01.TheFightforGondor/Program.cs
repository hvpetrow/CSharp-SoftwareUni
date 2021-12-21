using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse());
            Stack<int> orcs = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int counter = 1;

            while (orcs.Any() && plates.Any())
            {
                counter++;
                while (counter != waves)
                {
                    orcs = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
                    if (counter % 3 == 0)
                    {
                        int newPlate = int.Parse(Console.ReadLine());
                        plates.Push(newPlate);
                    }
                        break;
                }

                if (orcs.Peek() > plates.Peek())
                {
                    orcs.Push(orcs.Pop() - plates.Peek());
                    if (orcs.Peek() <= 0)
                    {
                        orcs.Pop();
                    }
                }
                else if (plates.Peek() > orcs.Peek())
                {
                    plates.Push(plates.Pop() - orcs.Peek());
                    orcs.Pop();
                }
                else
                {
                    plates.Pop();
                    orcs.Pop();
                }
            }

            Console.WriteLine(orcs.Any() ? "The orcs successfully destroyed the Gondor's defense." : "The people successfully repulsed the orc's attack.");
            Console.WriteLine(orcs.Any() ? $"Orcs left: {String.Join(", ", orcs) }" : $"Plates left: {String.Join(", ", plates)}");
        }
    }
}
