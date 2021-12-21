using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();



            for (int i = 0; i < limit; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split();
                string name = parts[0] ;
                if (parts.Length==4)
                {
                    bool removed = guest.Remove(name);
                    if (!removed)
                    {
                        Console.WriteLine($"{name} is not in the list! ");

                    }
                }
                else
                {
                    if (guest.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list! ");
                    }
                    else
                    {
                        guest.Add(name);

                    }
                }

            }
            foreach (var gues in guest)
            {
                Console.WriteLine(gues);
            }



        }
    }
}
