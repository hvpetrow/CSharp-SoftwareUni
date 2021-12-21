using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^(@\#+)(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])(@\#+)$");
            Regex digits = new Regex(@"\d+");

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                Match match = pattern.Match(text);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    MatchCollection digitMatch = digits.Matches(text);

                    if (digitMatch.Count == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else if (digitMatch.Count==1)
                    {
                        Match oneMatch = digits.Match(text);

                        Console.WriteLine($"Product group: {oneMatch.Value}");
                    }
                    else
                    {
                        string concat = string.Empty;

                        foreach (Match digit in digitMatch)
                        {
                            concat += digit.Value;


                        }
                            Console.WriteLine($"Product group: {concat}");
                    }
                }
            }
        }
    }
}
