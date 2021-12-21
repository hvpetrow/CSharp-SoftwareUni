using System;

namespace _02.Division.SyntaxLoops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
         int n = int.Parse(Console.ReadLine());
            bool isDivisible = false;
            int number = 0;



            if (n%10==0)
            {
                isDivisible = true;
                number = 10;

            }
            else if (n%7==0)
            {
                isDivisible = true;
                number = 7;
            }
            else if (n%6==0)
            {
                isDivisible = true;
                number = 6;
            }
            else if (n%3==0)
            {
                isDivisible = true;
                number = 3;
            }
            else if (n%2==0)
            {
                isDivisible = true;
                number = 2;

            }

            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by { number}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
