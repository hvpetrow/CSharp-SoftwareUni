using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < limit; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];

                if (input.Length<=3)
                {
                    bool isThere = false;
                    for (int j = 0; j < list.Count ; j++)
                    {
                      string  currentName = list[j];
                        if (name==currentName)
                        {
                            isThere = true;

                        }         
                    }
                    if (isThere==false)
                    {
                        list.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (input.Length>=4)
                {
                    bool isParticipant = false;
                    foreach (var participant in list)
                    {
                        if (name==participant)
                        {
                            isParticipant = true;

                        }
                    }
                    if (isParticipant == true)
                    {
                        list.Remove(name);

                    }

                    else
                    {
                        Console.WriteLine($"{ name} is not in the list!");
                    }
                }

            }
            Console.WriteLine(string.Join("" , list));
       
        }
    }
}
