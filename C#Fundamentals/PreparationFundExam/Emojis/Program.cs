using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emojis
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1");
            Regex digits = new Regex(@"\d");
            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);
            MatchCollection digitsMatches = digits.Matches(text);
            long threshold = 1;

            foreach (Match digit  in digitsMatches)
            {

            threshold *= long.Parse( digit.Value);

            }

            Console.WriteLine($"Cool threshold: {threshold}");

            List<string> list = new List<string>();

            foreach (Match match in matches)
            {
                long sum = 0;
                string emoji = match.Groups["emoji"].Value;

                foreach (char a in emoji )
                {
                    sum += a;
                }

                if (sum>threshold)
                {
                    list.Add(match.Value);
                }
            }



            Console.WriteLine($"{ matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join("\n" ,list ));





                    
        }
    }
}
