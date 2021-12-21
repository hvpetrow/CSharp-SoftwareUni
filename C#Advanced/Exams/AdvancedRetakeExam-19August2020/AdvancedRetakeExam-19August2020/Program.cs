using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRetakeExam_19August2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int storedFlowers = 0;
            int wreaths = 0;

            while (roses.Any() && lilies.Any())
            {
                if (roses.Peek() + lilies.Peek() == 15)
                {
                    wreaths++;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else if (roses.Peek() + lilies.Peek() > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                }
                else
                {
                    storedFlowers += lilies.Peek() + roses.Peek();
                    roses.Dequeue();
                    lilies.Pop();
                }
            }

            int addedWreaths = 0;
            if (storedFlowers >= 15)
            {
                addedWreaths = storedFlowers / 15;
            }
            wreaths += addedWreaths;

            if (wreaths < 5)
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
            else
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
        }
    }
}
