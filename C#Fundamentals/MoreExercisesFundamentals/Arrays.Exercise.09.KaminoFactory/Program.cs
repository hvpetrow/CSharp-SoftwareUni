using System;
using System.Linq;

namespace Arrays.Exercise._09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSequence = 0;

            int sequenceSize = 1;
            int currentStartIndex = 0;
            int bestStartingIndex = 0;
            bool leftMost = true;
            int bestSequenceSize = 0;
            int bestSequenceSum = 0;
            int[] bestSequenceArray = new int[n];
            int sample = 0;
            int bestSample = 1;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }
                int[] arr = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sample++;
                int sequenceSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sequenceSum += arr[i];

                }
                


                for (int i = 0; i < n; i++)
                {
                                    int currentNumber = arr[i];
                    sequenceSize = 1;
                    currentStartIndex = i;
                    if (currentNumber==0)
                    {
                        continue;
                    }
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        int rightNumber = arr[k];
                        if (currentNumber == 1 && currentNumber == rightNumber)
                        {
                            sequenceSize++;

                        }
                        else
                        {
                            break;
                        }
                    }
                    if (sequenceSize > bestSequence)
                    {
                        bestSequence = sequenceSize;
                        bestSequenceSize = currentStartIndex;
                        bestStartingIndex = currentStartIndex;
                        bestSequenceSum = sequenceSum;
                        bestSequenceArray = arr;
                        bestSample = sample;
                    }
                    else if (bestSequenceSize == sequenceSize)
                    {
                        if (i < bestStartingIndex)
                        {
                            bestSequence = sequenceSize;
                            bestSequenceSize = currentStartIndex;
                            bestStartingIndex = currentStartIndex;
                            bestSequenceSum = sequenceSum;
                            bestSequenceArray = arr;
                            bestSample = sample;
                        }
                        else if (bestStartingIndex == i && sequenceSum > bestSequenceSum)
                        {
                            bestSequence = sequenceSize;
                            bestSequenceSize = currentStartIndex;
                            bestStartingIndex = currentStartIndex;
                            bestSequenceSum = sequenceSum;
                            bestSequenceArray = arr;
                            bestSample = sample;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequenceArray));
        }
    }
}
