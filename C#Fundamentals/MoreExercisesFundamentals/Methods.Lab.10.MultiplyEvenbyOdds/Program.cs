using System;
using System.Linq;

namespace Methods.Lab._10.MultiplyEvenbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetSum(n);
            Console.WriteLine(result);

        }

        private static int GetOddSum(int n)
        {
            int sumOdd = 0;
            while (n != 0)
            {
                int number = n % 10;
                if (number % 2 != 0)
                {
                    sumOdd += number;
                }
                n /= 10;
            }
                return sumOdd;
        }
        private static int GetEvenSum(int n)
        {
            int sumEven = 0;
            while (n != 0)
            {
                int number = n % 10;
                if (number % 2 != 0)
                {
                    sumEven += number;
                }
                n /= 10;
            }
            return sumEven;
        }
         static int GetSum (int n )
        {
            int result = GetEvenSum(n) * GetOddSum(n);
            return result;


        }
    }
}
