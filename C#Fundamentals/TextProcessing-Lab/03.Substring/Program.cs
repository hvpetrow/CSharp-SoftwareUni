using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWord = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(bannedWord))
            {
                int index = word.IndexOf(bannedWord);
                word = word.Remove(index, bannedWord.Length);

            }
            Console.WriteLine(word);
        }
    }
}
