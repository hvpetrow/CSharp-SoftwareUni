using System;
using System.Linq;

namespace Methods.Exercise._11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] line = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstWord = line[0];
                string secondWord = line[1];


                if (firstWord == "exchange")
                {
                    int exchangeIndex = int.Parse(secondWord);
                    Exchange(arr1, exchangeIndex);
                    Console.WriteLine(ex);
                }
                else if (firstWord == "max")
                {
                    secondWord = line[1];
                    int idx = GetMax(arr1, secondWord);

                    if (idx == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(idx);
                    }

                }
                else if (firstWord == "min")
                {
                    secondWord = line[1];
                    int idx = GetMin(arr1, secondWord);
                }
                else if (firstWord == "first")
                {
                    int count = int.Parse(secondWord);
                    string parameter = line[2];
                    if (count>arr1.Length)
                    {
                        continue;
                    }

                    int[] firstElements = GetFirstElements(arr1, count, parameter);
                    Console.Write("[");
                    bool found = false;
                    foreach (var element in firstElements)
                    {
                        if (element!=-1)
                        {
                            Console.Write($", {element}");
                        }
                        else
                        {
                            Console.Write(element);
                            found = true;

                        }
                    }
                    Console.WriteLine("]");
                }
                else if (firstWord == "last")
                {
                }
            }
        }
        private static int[] GetFirstElements(int [] arr1 , int count , string parameter)
        {
            
            int[] result = new int[count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }
            int parity = 1;
            int idx = 0;
            if (parameter == "even")
            {
                parity = 0;
            }
            foreach (var item in arr1)
            {
                if (item%2==parity)
                {
                    result[idx] = item;
                    idx++;
                    if (idx>=result.Length)
                    {
                        break;
                    }
                }
            }
            return result;
        
        }
        private static void Exchange(int[] arr1, int exchangeIndex)
        {
            if (exchangeIndex >= arr1.Length || exchangeIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            for (int rotation = 0; rotation <= exchangeIndex; rotation++)
            {

                int firstNumber = arr1[0];
                for (int i = 1; i < arr1.Length; i++)
                {
                    arr1[i - 1] = arr1[i];

                }
                arr1[arr1.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join);
        }
        private static int GetMax(int[] arr1, string secondWord)
        {
            int parity = 1;
            if (secondWord == "even")
            {
                parity = 0;
            }
            int maxNumber = int.MinValue;
            int idx = -1;

            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNumber = arr1[i];
                if (currentNumber >= maxNumber && currentNumber % 2 == parity)
                {
                    maxNumber = currentNumber;
                    idx = i;
                }
            }
            return idx;

        }
        private static int GetMin(int[] arr1, string secondWord)
        {
            int parity = 1;
            if (secondWord == "even")
            {
                parity = 0;
            }
            int minNumber = int.MaxValue;
            int idx = -1;

            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNumber = arr1[i];
                if (currentNumber <= minNumber && currentNumber % 2 == parity)
                {
                    minNumber = currentNumber;
                    idx = i;
                }
            }
            return idx;
        }
    }
}
