using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contest = new Dictionary<string, string>();
            //Part One Interview:success
            var results = new Dictionary<string, Dictionary<string, int>>();
            //C# Fundamentals=>fundPass=>Tanya=>350
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] parts = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string cont = parts[0];
                string passwordContest = parts[1];

                if (!contest.ContainsKey(cont))
                {
                    contest.Add(cont, passwordContest);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] parts = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cont = parts[0];
                string passwordContest = parts[1];
                string username = parts[2];
                int points = int.Parse(parts[3]);

                if (contest.ContainsKey(cont) && contest[cont] == passwordContest)
                {
                    if (!results.ContainsKey(username))
                    {
                        results.Add(username, new Dictionary<string, int>());
                    }
                    if (results[username].ContainsKey(cont))
                    {
                        if (results[username][cont] < points)
                        {
                            results[username][cont] = points;
                            continue;

                        }
                        else
                        {
                            continue;
                        }
                    }

                    results[username].Add(cont, points);
                }
            }
            var bestUser = string.Empty;
            var bestPoints = 0;

            foreach (var user in results)
            {
                var sum = 0;
                foreach (var contes in user.Value)
                {
                    sum += contes.Value;
                }
                if (sum > bestPoints)
                {
                    bestPoints = sum;
                    bestUser = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            var sortedDictionary = results.OrderBy(x => x.Key);

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine(item.Key);
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }


        }
    }
}
