using System;

namespace _05.PrintPartOfASCIITable.DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();

        }
    }
}
