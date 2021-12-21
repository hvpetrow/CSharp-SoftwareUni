using System;
using System.Text;
using System.Linq;

namespace _05.Digits_LettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    digits.Append(item);   
                }
                else if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else
                {
                    symbols.Append(item);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
