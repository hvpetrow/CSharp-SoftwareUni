using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command=="subtract")
            {
                Subtract(a,b);
            }
            else if (command=="multiply")
            {
                Multiply(a, b);

            }
            else if (command=="divide")
            {
                Divide(a, b);

            }
            else
            {
                Add(a, b);

            }



            
        }
        static void Subtract(int a,int b)
        {
            int c = a - b;
            Console.WriteLine(c);

        }
        static void Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine(c);
        }
        static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        static void Divide(int a, int b)
        {
            int c = a / b;
            Console.WriteLine(c);


        }
    }
}
