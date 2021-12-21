using System;
using System.Text.RegularExpressions;

namespace Adastra
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(#|\|)(?<item>[A-Za-z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]{1,4}|10000)\1");

            string input = Console.ReadLine();


            MatchCollection matches = regex.Matches(input);
            int sum = 0;

            foreach (Match match in matches)
            {
               int calories = int.Parse ( match.Groups["calories"].Value);
                sum += calories;
            }

            int days =  sum / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match food in matches)
            {
                string item = food.Groups["item"].Value;
                string date = food.Groups["date"].Value;
                string nutrition = food.Groups["calories"].Value;

                Console.WriteLine($"Item: {item}, Best before: {date}, Nutrition: {nutrition}");
            }
        }
    }
}
