using System;
using System.Linq;

namespace Arrays.Exercise._03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] redArray = new int[n];
            int[] blueArray = new int[n];
            int firstNumber = 0;
            int secondNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

                for (int k = 0; k < numbers.Length-1; k++)
                {
                    if (i%2==0)
                    {
                  firstNumber = numbers[k];
                  secondNumber = numbers[k+1];

                    }
                    else
                    {
                        secondNumber = numbers[k];
                        firstNumber = numbers[k + 1];
                    }
                }
                redArray[i] = firstNumber;
                blueArray[i] = secondNumber;
                
            }
            foreach (var item in redArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
                foreach(var item2 in blueArray)
                    {
                Console.Write(item2 + " "  );

            
            }
         


        }
    }
}
