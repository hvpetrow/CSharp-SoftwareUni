using System;

namespace Methods.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string operatorr= Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            int result = GetResult(operatorr, number1, number2);
            Console.WriteLine(result);
         

        }
        static int GetResult(string operatorr, int number1, int number2 )
        {
            int result = 0;
            if (operatorr == "+")
            {
                 result = number1 + number2;
            }
            else if (operatorr == "-")
            {
                 result = number1 - number2;

            }
            else if (operatorr == "*")
            {
                result = number1 * number2;

            }
            else if (operatorr == "/")
            {
                result = number1 / number2;

            }
            return result;


        }
    }
}
