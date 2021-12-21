using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double result = Factorial(number);
            double result2 = Factorial(number2);
            double result3 = result / result2;
            Console.WriteLine($"{result3:F2}");
        }

        private static double Factorial(int number)
        {
            double result = 1;
            while (number!=1)
            {
                result *= number;
                number -= 1; 

            }
            return result;

        }

       
    }
}
