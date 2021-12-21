using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> guests = new SortedSet<string>();
            bool flag = false;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                else if (line == "PARTY")
                {
                    while (true)
                    {
                        line = Console.ReadLine();
                        if (line == "END")
                        {
                            flag = true;
                            break;
                        }

                        if (guests.Contains(line))
                        {
                            guests.Remove(line);
                        }
                    }
                }
                else
                {
                    guests.Add(line);
                }
                if (flag == true)
                {
                    break;
                }
            }

            var sum = guests.Count;
            Console.WriteLine(sum);

            foreach (var item in guests)
            {
                if (char.IsDigit(item[0]))
                {
                    Console.WriteLine(item);
                }
              
            }

            foreach (var item in guests)
            {
                if (char.IsLetter(item[0]))
                {
                    Console.WriteLine(item);

                }
            }

          
        }
    }
}
