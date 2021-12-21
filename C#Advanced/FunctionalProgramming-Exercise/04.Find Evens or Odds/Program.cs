using System;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string keyWord = Console.ReadLine();

            Predicate<int> predicate = null;

            if (keyWord=="even")
            {
                predicate = i => i % 2 == 0;
            }
            else if (keyWord=="odd")
            {
                predicate = i => i % 2 != 0;
            
            }

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
