using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Go Shopping!")
                {
                    break;
                }
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string item = tokens[1];

                if (command=="Urgent")
                {
                    if (list.Contains(item)==false)
                    {
                        list.Insert(0, item);
                    }
                }
                else if (command=="Unnecessary")
                {
                    bool isExisting = list.Contains(item);
                    if (isExisting==true)
                    {
                        list.Remove(item);

                    }
                }
                else if (command== "Correct")
                {
                    string newItem = tokens[2];
                    bool isThere = list.Contains(item);
                    int index = list.IndexOf(item);

                    if (isThere==true)
                    {
                        item = newItem;
                        list[index] = newItem;

                    }
                }
                else if (command== "Rearrange")
                {
                    bool isExisting = list.Contains(item);
                    int currentPosition = list.IndexOf(item);
                    if (isExisting == true)
                    {
                        list.Add(item);
                        list.RemoveAt(currentPosition);
                        
                    }
                }
            }

            Console.WriteLine(String.Join(", " , list));

            
        }
    }
}
