using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(AreaMethod(a, b));

        }

        static int AreaMethod(int a , int b)
        {
            int c = a * b;
            return c;
        
        
        
        }
    }
}
