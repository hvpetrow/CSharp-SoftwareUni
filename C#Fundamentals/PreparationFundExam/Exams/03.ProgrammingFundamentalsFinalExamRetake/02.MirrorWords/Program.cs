using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1");

           List<string> list = new List<string>();

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                string substring = match.Value;
                string reversed = string.Empty;
                string normalWord = string.Empty;
                string secondWord = string.Empty;
                
                for (int i = 1; i < substring.Length/2-1; i++)
                {
                    normalWord += substring[i];
                }
               
                for (int i = substring.Length - 2; i >= substring.Length / 2+1; i--)
                {
                    secondWord += substring[i];
                }

                if (normalWord==secondWord)
                {
                    for (int i = secondWord.Length - 1; i >= 0; i--)
                    {
                        reversed += secondWord[i];
                    }
                    string finalWord = normalWord + " <=> " + reversed;
                    list.Add(finalWord);
                }
            }
            if (matches.Count==0)
            {
                Console.WriteLine("No word pairs found!");
              
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (list.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", list));

            }
        }
    }
}
