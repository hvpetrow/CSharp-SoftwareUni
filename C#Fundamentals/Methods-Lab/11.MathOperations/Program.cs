using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(OpMethode(number, op, number2));

            static double OpMethode(int n, string op, int n2)
            {
                if (op == "*")
                {
                    double result = n * n2;
                    return result;
                }
                else if (op == "-")
                {
                    double result = n - n2;
                    return result;
                }
                else if (op == "+")
                {
                    double result = n + n2;
                    return result;

                }
                else
                {
                    double result = n / n2;
                    
                    return  result;

                }
            
            }
        }
    }
}
