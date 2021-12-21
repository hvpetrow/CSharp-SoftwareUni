using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = ResultMethod(number);
            Console.WriteLine(result);

        }
        static int FindEvenSum(int num)
        {
            int sumEven = 0;
            while (num != 0)
            {
                int n = num % 10;
                if (n % 2 == 0)
                {
                    sumEven += n;
                }
                num /= 10;

            }
            return sumEven;
        }

        static int FindOddSum(int num)
        {
            int sumOdd = 0;
            while (num != 0)
            {
                int n = num % 10;
                if (n % 2 != 0)
                {
                    sumOdd += n;
                }
                num /= 10;

            }
            return sumOdd;
        }
        static int ResultMethod(int num)
        {
            int result = FindEvenSum(num) * FindOddSum(num);
            return result;

        }
    }
}


