using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var dictionary = new Dictionary<string, Predicate<string>>();

            string command = Console.ReadLine();

            while (command!="Print")
            {
                string[] commandArgs = command.Split(";" , StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string predicateAction = commandArgs[1];
                string value = commandArgs[2];
                string key = predicateAction + "_" + value;

                if (action=="Add filter")
                {
                    Predicate<string> predicate = GetPredicate(predicateAction, value);
                    dictionary.Add(key, predicate);

                }
                else
                {
                    dictionary.Remove(key);
                }

                command = Console.ReadLine();
            }

                foreach (var  kvp in dictionary)
                {
                    names.RemoveAll(kvp.Value);

                }

            Console.WriteLine(String.Join(" " , names));


        }
        private static Predicate<string> GetPredicate(string commandInfo, string param)
        {
            if (commandInfo == "Starts with")
            {
                return x => x.StartsWith(x);
            }
            if (commandInfo == "Ends with")
            {
                return x => x.EndsWith(param);
            }
            if (commandInfo == "Contains")
            {
                return x => x.Contains(param);
            }
            

            int length = int.Parse(param);

            return x => x.Length == length;
        }
    }
}
