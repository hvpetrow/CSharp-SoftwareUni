using System;

namespace _02.SumDigits.DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while (n>0)
            {
                int digits = n % 10;
                sum += digits;
                n /= 10;

            }
            Console.WriteLine(sum);

        }
    }
}
