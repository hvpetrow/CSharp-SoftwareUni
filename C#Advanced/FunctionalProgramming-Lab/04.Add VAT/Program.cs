using System;
using System.Linq;

namespace _04.Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x=> x*1.2);



            foreach (var number in numbers)
            {
                Console.WriteLine($"{ number:F2}");
            }   
        }
    }
}
