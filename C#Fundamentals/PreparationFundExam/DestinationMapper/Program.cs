using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(=|\/)(?<country>[A-Z][A-Za-z]{2,})\1");

            MatchCollection matches = regex.Matches(input);
            List<string> countrys = new List<string>();

            int sumTravelPoints = 0;

            foreach (Match match in matches)
            {
                string country = match.Groups["country"].Value;

                sumTravelPoints += country.Length;
                countrys.Add(country);
            }

            Console.WriteLine($"Destinations: {String.Join(", " , countrys)}");
            Console.WriteLine($"Travel Points: {sumTravelPoints}");
        }
    }
}
