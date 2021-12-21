using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse());
            var orcs = new Stack<int>();
            bool flag = false;

            for (int i = 1; i <= waves; i++)
            {
               orcs = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plates.Push(newPlate);
                    int[] newOrder = plates.ToArray();
                    plates = new Stack<int>(newOrder);
                }
               

                while (orcs.Any() && plates.Any())
                {
                    if (orcs.Peek() > plates.Peek())
                    {
                        orcs.Push(orcs.Pop() - plates.Peek());
                        plates.Pop();
                       
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
                    if (plates.Count == 0)
                    {
                        flag = true;
                    }
                }
                if (flag==true)
                {
                    break;
                }
            }
            Console.WriteLine(orcs.Any() ? "The orcs successfully destroyed the Gondor's defense." : "The people successfully repulsed the orc's attack.");
            Console.WriteLine(orcs.Any() ? $"Orcs left: {String.Join(", ", orcs) }" : $"Plates left: {String.Join(", ", plates)}");
        }
    }
}

