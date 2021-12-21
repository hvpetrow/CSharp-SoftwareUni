using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam2310
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            HashSet<char> chars = new HashSet<char>();
            string[] words = new string[] { "pear", "flour", "pork", "olive" };

            while (consonants.Any())
            {
                foreach (var word in words)
                {
                    if (word.Contains(vowels.Peek()))
                    {
                        chars.Add(vowels.Peek());
                        
                    }
                    if (word.Contains(consonants.Peek()))
                    {
                        chars.Add(consonants.Peek());
                    }
                }
                vowels.Enqueue(vowels.Dequeue());
                consonants.Pop();
            }

            List<string> successfullWords = new List<string>();

            foreach (var word in words)
            {
                bool wordSuccessful = true;

                foreach (var charr in word)
                {
                    if (!chars.Contains(charr))
                    {
                        wordSuccessful= false;
                    }

                }
                if (wordSuccessful == true)
                {
                    successfullWords.Add(word);
                }
            }

            Console.WriteLine($"Words found: {successfullWords.Count}");
            foreach (var word in successfullWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
