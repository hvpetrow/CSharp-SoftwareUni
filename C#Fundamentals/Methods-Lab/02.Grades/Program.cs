using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeCalculator(grade);

        }
        static void GradeCalculator(double number)
        {
            string result = string.Empty;
            if (number<=2.99)
            {
                result = "Fail"; 

            }
            else if (number>=3.00 && number<=3.49)
            {
                result = "Poor"; 
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                result = "Good";
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                result = "Very good";
            }
            else
            {
                result = "Excellent";
            }
            Console.WriteLine(result);


        }
    }
}
