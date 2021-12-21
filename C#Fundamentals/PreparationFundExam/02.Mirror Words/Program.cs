using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(@|#){1}(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1");

            MatchCollection matches = regex.Matches(text);
            List<string> mirrorWords = new List<string>();

            if (matches.Count==0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match match in matches)
            {
                string firstMatch = match.Groups["first"].Value;
                string secondMatch= match.Groups["second"].Value;
                string reversed = string.Empty;

                for (int i = secondMatch.Length - 1; i >= 0; i--)
                {
                    reversed += secondMatch[i];
                }

                string words = string.Empty;
                words += firstMatch + " <=> " + secondMatch;


                if (firstMatch==reversed)
                {
                    mirrorWords.Add(words);
                }
            }

            if (mirrorWords.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:\n{String.Join(", " , mirrorWords)}");
            }
        }
    }
}
