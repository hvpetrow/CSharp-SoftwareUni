using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }

        static long Factoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long sum = n * Factoriel(n - 1);
            return sum;
        }
    }
}
