using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<=)(=|\/)(?<country>[A-Z][A-Za-z]{2,})\1");
            List<string> list = new List<string>();

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            int sum = 0;

            foreach (Match match in matches)
            {
                string country = match.Groups["country"].Value;
                sum += country.Length;

                list.Add(country);
            }

            Console.WriteLine($"Destinations: {String.Join(", " , list)}");
            Console.WriteLine($"Travel Points: {sum}");

        }
    }
}
