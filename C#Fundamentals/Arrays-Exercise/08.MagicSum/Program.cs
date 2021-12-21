using System;
using System.Linq;
 


namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
       .Select(int.Parse)
       .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int nextNumber = array[j];
                    if (currentNumber+nextNumber==magicNumber)
                    {
                        Console.WriteLine($"{currentNumber} {nextNumber}");
                        
                    }
                }
            }

        }
    }
}
