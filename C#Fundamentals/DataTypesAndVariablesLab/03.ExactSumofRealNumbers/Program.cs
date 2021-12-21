using System;

namespace _03.ExactSumofRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                sum += number; 

            }




            Console.WriteLine(sum); 



        }
    }
}
