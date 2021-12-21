using System;
using System.Linq;

namespace _07.MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            int maxSequence = 0;
            int maxNumber = 0;
            bool max = false;

            for (int i = 0; i < arr.Length; i++)
            {
             
                int currentNumber = arr[i];
                int counter = 1;

                for (int j = i+1; j < arr.Length; j++)
                {
                   int nextNumber = arr[j];
                    if (currentNumber==nextNumber)
                    {
                        counter++;
                       
                        if (counter> maxSequence)
                        {
                            maxSequence = counter;
                            maxNumber = currentNumber;
                           max = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (max==true)
            {
                for (int k = 0; k < maxSequence; k++)
                {
                    Console.Write($"{maxNumber} ");
                }
            }
        }
    }
}
