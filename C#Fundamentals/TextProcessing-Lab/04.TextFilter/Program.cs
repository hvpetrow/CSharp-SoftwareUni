using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWord)
            {            
                       text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);

        }
    }
}
