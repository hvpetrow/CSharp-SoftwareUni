using System;
using System.Linq;


namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
          
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                int currentNumber = array[i];
                for (int j = i+1 ; j < array.Length; j++)
                {
                    int nextNumber = array[j];
                    if (nextNumber>=currentNumber)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    Console.Write($"{currentNumber} ");

                }

            }
            Console.WriteLine();

        }
    }
}
