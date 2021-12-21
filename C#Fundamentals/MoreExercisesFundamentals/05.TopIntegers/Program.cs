using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arr1.Length; i++)
            {
            bool isBigInteger = true;
                int currentNumber = arr1[i];
                int lastNumber = arr1[arr1.Length - 1];
                for (int j = i+1; j < arr1.Length; j++)
                {
                   
                    int nextNumber = arr1[j];
                    if (currentNumber<=nextNumber)
                    {
                        isBigInteger = false;
                        break;
                    }
                }
                if (isBigInteger == true)
                {
                    Console.Write(currentNumber + " " );
                }
             
                
            }
            

        }
    }
}
