using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        
            Console.WriteLine(SignMethod(n));
        }
        static string SignMethod(int number)
        {
            string sign = null;

            if (number>0)
            {
                sign = "positive";
            }
            else if (number<0)
            {
                sign = "negative"; 
            }
            else
            {
                sign = "zero";

            }
            return $"The number {number} is {sign}.";
          }
    }
}
