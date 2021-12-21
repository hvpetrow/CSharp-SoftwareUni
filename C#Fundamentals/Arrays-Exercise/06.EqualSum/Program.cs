using System;
using System.Linq;


namespace _06.EqualSum
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
                int currentNumber = array[i];
                int currentIndex = i;

                int leftSum = 0;
                int rightSum = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                   
                    rightSum += array[j];
                 
                }

                for (int k = i - 1; k >= 0 ; k--)
                {
                    
                    leftSum += array[k];

                }
               
                
                if (leftSum==rightSum)
                {
                    Console.WriteLine($"{currentIndex}");
                    return;

                }
              
            }
                Console.WriteLine("no");
            
        }
    }
}
