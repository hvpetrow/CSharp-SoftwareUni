using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length%2==0)
            {

              string result = StringerEven(input);
                Console.WriteLine(result);
            }
            else
            {
              string result = StringerOdd(input);
                Console.WriteLine(result);

            }

        }





        static string StringerEven(string input)
        {
          int i = input.Length / 2;
            string halfString = input.Substring(i-1,    2);
            return halfString;


        }
        static string StringerOdd(string input)
        {
            int i = input.Length / 2;
            string halfString = input.Substring(i, 1);
            return halfString;


        }

    }
}
