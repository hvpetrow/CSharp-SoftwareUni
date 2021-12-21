using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = SubtractMethod(first, second, third);
            Console.WriteLine(result);

        }
        static int PlusMethod(int first, int second)
        {
            int midResult = first + second;
            return midResult; 

        
        
        }

        private static int SubtractMethod(int first , int second ,int third)
        {
           int midResult =  PlusMethod(first, second);
            int result = midResult - third;
            return result; 
        
        }






    }
}
