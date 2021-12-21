using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2task
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<word>[A-Za-z]{8,})\]");
            List<int> list = new List<int>();

            int n = int.Parse(Console.ReadLine());
            
          


            for (int j = 0; j < n; j++)
            {
                string text = Console.ReadLine();

                Match match = regex.Match(text);

                if (match.Success)
                {
                    string word = match.Groups["word"].Value;
                    string command = match.Groups["command"].Value;

                    foreach (char a in word)
                    {
                        int aInt = (int)a;
                        list.Add(aInt);
                    }
                    Console.WriteLine($"{ command}: {String.Join(" " , list)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }

        }
    }
}
