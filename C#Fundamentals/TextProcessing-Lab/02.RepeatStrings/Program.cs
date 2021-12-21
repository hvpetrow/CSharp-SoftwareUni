using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in array)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
