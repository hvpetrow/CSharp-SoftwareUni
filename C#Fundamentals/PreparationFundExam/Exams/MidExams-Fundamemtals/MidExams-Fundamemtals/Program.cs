using System;

namespace MidExams_Fundamemtals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
           double initialBonus = double.Parse(Console.ReadLine());

           
            double bestAttendance = 0;
            double max = 0;

            for (int i = 0; i < n; i++)
            {
                double attendance = double.Parse(Console.ReadLine());

                double totalBonus = (double)(attendance * 1.0 / lecturesCount * 1.0) * (5 + initialBonus);

                if (totalBonus > max)
                {
                    max = totalBonus;
                    bestAttendance = attendance;

                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {bestAttendance } lectures.");



        }
    }
}