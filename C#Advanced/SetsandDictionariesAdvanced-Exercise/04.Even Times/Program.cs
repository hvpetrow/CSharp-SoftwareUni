using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(number))
                {
                dictionary.Add(number,0);

                }

                dictionary[number]++;
            }

            //int nmr = dictionary.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;

            foreach (var item in dictionary)
            {
                int key = item.Key;
                int value = item.Value;

                if (value%2==0)
                {
                    Console.WriteLine(key);
                    return;
                }
            }
        }
    }
}
