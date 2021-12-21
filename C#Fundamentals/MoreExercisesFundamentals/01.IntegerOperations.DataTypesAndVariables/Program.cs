using System;

namespace _01.IntegerOperations.DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourthNumber = long.Parse(Console.ReadLine());

            long result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;

            Console.WriteLine(result);
        }
    }
}
