using System;
using System.Linq;


namespace CommonElements02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            string[] arr2 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word1 in arr2)
            {
                foreach (var word2 in arr)
                {
                    if (word1==word2)
                    {
                    Console.Write($"{word1} ");

                    }
                }
            }

        }
    }
}
