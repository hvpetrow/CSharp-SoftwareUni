using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);

        }
        static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int sumOfDigits = 0;
                string currentDigit = string.Empty;
                string numberAsString =currentNumber.ToString();
                for (int j = 0; j < numberAsString.Length; j++)
                {
                    currentDigit += (numberAsString[j]);
                  
                }

            }
        }



    }
}
