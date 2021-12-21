using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex emojies = new Regex(@"([::**]{2})(?<emoji>[A-Z][a-z]{2,})(\1)");
            Regex digits = new Regex(@"\d");

            MatchCollection emojiCollection = emojies.Matches(text);
            MatchCollection digitsCollection = digits.Matches(text);

            int sumDigits = 1;

            foreach (Match digit in digitsCollection)
            {
                sumDigits *= int.Parse(digit.Value);

            }

            List<string> list = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (  Match emoji in emojiCollection)
            {
                list.Add(emoji.Value);

            }

                int startIndex = 2;
                int sum = 0;

            foreach (var item in list)
            {
                int endIndex = item.Length- startIndex;

                for (int i = startIndex; i < endIndex; i++)
                {
                    sum += item[i];
                }

                dict.Add(item, sum);
                sum = 0;

            }

            Dictionary<string, int> sorted = dict.Where(x=>x.Value>=sumDigits).ToDictionary(a=>a.Key , x=>x.Value);

            Console.WriteLine($"Cool threshold: {sumDigits}");
            Console.WriteLine($"{list.Count } emojis found in the text. The cool ones are:");

            foreach (var item in sorted)
            {
                Console.WriteLine(item.Key);
            }




        }
    }
}
