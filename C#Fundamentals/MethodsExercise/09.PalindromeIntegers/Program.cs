using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PalindromeIntegers(input);
           
        }

        private static void PalindromeIntegers(string input)
        {
            while (input != "END")
            {
                string reverse = string.Empty;
                if (input=="END")
                {
                    break;
                }
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i]; 

                }
                if (reverse==input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                reverse = string.Empty;


                input = Console.ReadLine();
            }
        }
    }
}
