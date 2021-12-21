using System;

namespace Methods.Lab.GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            GetMAx(input, first, second);
        }
        static void GetMAx(string input ,string first, string second)
        {
            if (input == "int")
            {
                int first1 = int.Parse(first);
                int second2 = int.Parse(second);
               
                if (first1 > second2)
                {
                    Console.WriteLine(first1);
                }
                else
                {
                    Console.WriteLine(second2);

                }
            }
            else if (input == "string")
            {

                if (first.CompareTo(second) >= 0)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);

                }
            }
            else if (input == "char")
            {
                char firstChar = char.Parse(first);
                char secondChar = char.Parse(second);

                if (firstChar > secondChar)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);
                }

            }


        }
    }
}
