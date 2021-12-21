using System;

namespace Methods.Exercise.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GetTopInteger(n);
        }

        private static void GetTopInteger(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool isDivideBy8 = false;
                bool isOddDigit = false;
                int sumOfDigits = 0;
                int currentNumber = i;
                while (currentNumber != 0)
                {

                    int currentDigit = currentNumber % 10;
                    sumOfDigits += currentDigit;
                    if (currentDigit % 2 != 0)
                    {
                        isOddDigit = true;
                    }
                    currentNumber /= 10;
                }
                if (sumOfDigits % 8 == 0)
                {
                    isDivideBy8 = true;
                }

                if (isDivideBy8 == true && isOddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
