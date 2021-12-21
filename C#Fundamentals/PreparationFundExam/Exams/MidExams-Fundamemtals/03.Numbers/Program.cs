using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> newSequence = new List<int>();

           double averageValue = 0;

            foreach (var number in sequence)
            {
                averageValue += number;
            }

            averageValue /= sequence.Count;


            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] > averageValue)
                {
                    newSequence.Add(sequence[i]);
                }
            }
            if (newSequence.Count<=0)
            {
                Console.WriteLine("No");
                return;
                
            }
            newSequence.Sort();
            newSequence.Reverse();
            List<int> resultList = new List<int>();

            for (int j = 0; j < newSequence.Count; j++)
            {
                resultList.Add( newSequence[j]);
                Console.Write(resultList[j] + " ");
                if (j==4)
                {
                    return;
                }
            }

            
        }
    }
}
