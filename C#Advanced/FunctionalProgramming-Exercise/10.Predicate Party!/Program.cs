using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Party!")
                {
                    break;
                }

                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Predicate<string> predicate = GetPredicate(commandInfo[1], commandInfo[2]);             

                if (commandInfo[0]== "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (commandInfo[0] =="Double")
                {
                    List<string> doubledNames = names.FindAll(predicate);
                    if (doubledNames.Any())
                    {
                        int index = names.FindIndex(predicate);
                        names.InsertRange(index, doubledNames);

                    }
                }

            }
            if (names.Any())
            {
                Console.WriteLine($"{String.Join(", " , names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string commandInfo, string param)
        {
            if (commandInfo=="StartsWith")
            {
                return x => x.StartsWith(x);
            }
            if (commandInfo=="EndsWith")
            {
                return x => x.EndsWith(param);
            }

            int length = int.Parse(param);

            return x => x.Length == length;
        }
    }
}
