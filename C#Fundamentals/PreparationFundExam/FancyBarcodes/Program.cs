using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"@#+(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])@#+");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string barcode = match.Groups["barcode"].Value;
                string productGrop = string.Empty;
                bool flag = true;

                foreach (char item in barcode)
                {

                    if (char.IsDigit(item))
                    {
                        productGrop += item;
                        flag = false;
                    }

                }
                if (flag==false)
                {
                Console.WriteLine($"Product group: {productGrop}");

                }
                else
                {
                    Console.WriteLine("Product group: 00");
                }

            }
        }
    }
}
