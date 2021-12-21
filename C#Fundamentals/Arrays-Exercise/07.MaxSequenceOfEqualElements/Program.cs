using System;
using System.Linq;


namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();


            int bestSequenceSize= 0;
            int bestSequenceNumber = 0;
            int bestStartingIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int sequneceSize = 1;
                int currentNumber = array[i] ;
                int currentIndex = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    int rightNumber = array[j];
                    if (currentNumber==rightNumber)
                    {
                        sequneceSize += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequneceSize>bestSequenceSize)
                {
                    bestSequenceSize = sequneceSize;
                    bestSequenceNumber = currentNumber;
                    bestStartingIndex = currentIndex;

                }
                else if (bestSequenceSize ==sequneceSize)
                {
                    if (i<bestStartingIndex)
                    {

                    }
                }

            }
            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNumber} ");
            }
            Console.WriteLine();


        }
    }
}
