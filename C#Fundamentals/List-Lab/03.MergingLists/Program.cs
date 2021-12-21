using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>(firstList.Count + secondList.Count);
            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                numbers.Add(firstList[i]);
                numbers.Add(secondList[i]);

            }
            if (firstList.Count!=secondList.Count)
            {
                if (firstList.Count>secondList.Count)
                {
                     numbers.AddRange(GetRemindingList(firstList, secondList));
                }
                else
                {
                    numbers.AddRange(GetRemindingList(secondList, firstList)) ;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
        static List<int> GetRemindingList (List<int> longerList , List<int> shorterList)
        {
            if (longerList.Count<=shorterList.Count)
            {
                throw new  ArgumentException();

            }
            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);

            }
            return result;





        }
    }
}
