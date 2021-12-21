using System;

namespace _09.SpiceMustFlow.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            long totalSpice = 0;
            int days = 0;
            if (yield<100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
            while (yield>=100)
            {
                days += 1;
                totalSpice += yield - 26;
                yield -= 10;



            }
            totalSpice -= 26;

            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
