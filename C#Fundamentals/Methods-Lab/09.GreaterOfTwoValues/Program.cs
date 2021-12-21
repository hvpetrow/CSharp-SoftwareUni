using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            GetMax(input, one, two);
            //if (input == "int")
            //{
            //    int number1 = int.Parse(Console.ReadLine());
            //    int number2 = int.Parse(Console.ReadLine());
            //}
            //else if (input == "char")
            //{
            //    string firstChar = Console.ReadLine();
            //    string secondChar = Console.ReadLine();

            //}
            //else
            //{
            //    string firstString = Console.ReadLine();
            //    string secondString = Console.ReadLine();
            //}



        }
        static void GetMax(string command , string first, string second)
        {
            if (command=="int")
            {
                int number1 = int.Parse(first);
                int number2 = int.Parse(second);
                int greaterNumber = 0;
                if (number1>number2)
                {
                    greaterNumber = number1;
                    Console.WriteLine(greaterNumber);
                }
                else
                {
                    greaterNumber = number2;
                    Console.WriteLine(greaterNumber);
                }
            }
            else if (command=="char")
            {
               char asciiValue = char.Parse(first);
                char asciiValue2 = char.Parse(second);
                
                if (asciiValue>asciiValue2)
                {
                   
                    Console.WriteLine(asciiValue);
                }
                else
                {
                 
                    Console.WriteLine(asciiValue2);
                }
            }
            else
            {
                if (first.CompareTo(second)>=0)
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
