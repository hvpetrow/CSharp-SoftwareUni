using System;
using System.Linq;


namespace TextProcessing_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word=="end")
                {
                    break;
                }

                char[] reversedWord = word.Reverse().ToArray();

                Console.WriteLine($"{word} = {(String.Join("" ,reversedWord))}");
            }
        }
    }
}
