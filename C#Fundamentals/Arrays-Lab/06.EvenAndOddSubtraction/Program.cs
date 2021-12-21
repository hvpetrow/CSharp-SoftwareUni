using System;
using System.Linq; 


namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                if (currentNumber%2==0)
                {
                    evenSum += currentNumber; 



                }
                else
                {
                    oddSum += currentNumber;




                }
            }
            int wholeSum = evenSum - oddSum; 
            Console.WriteLine(wholeSum);


        }
    }
}
