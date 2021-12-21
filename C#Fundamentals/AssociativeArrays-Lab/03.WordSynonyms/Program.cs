using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonim);
                }
                else
                {
                    dictionary.Add(word,new List<string>() { synonim});
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", " , item.Value)}");
            }
        }
    }
}
