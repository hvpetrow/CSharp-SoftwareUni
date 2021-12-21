using System;

namespace _04.CenturiestoMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            long years = centures * 100;
             float days = years * 365.2422F;
            int hours = (int)days * 24; 

        }
    }
}
