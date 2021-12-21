using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Retake_Exam_14April2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputHats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputScarfs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> hats = new Stack<int>(inputHats);
            Queue<int> scarfs = new Queue<int>(inputScarfs);
            List<int> sets = new List<int>();
            bool isChangedHatValue = false;

            while (true)
            {
                if (!hats.Any() || !scarfs.Any())
                {
                    break;
                }

                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if (isChangedHatValue == true)
                {
                    hat++;
                }
                isChangedHatValue = false;

                if (hat > scarf)
                {
                    int set = hat + scarf;
                    sets.Add(set);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (hat < scarf)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    isChangedHatValue = true;
                }
            }

            int mostExpensiveSet = sets.Max();
            Console.WriteLine($"The most expensive set is: {mostExpensiveSet}");
            Console.WriteLine(String.Join(" ", sets));
        }
    }
}
