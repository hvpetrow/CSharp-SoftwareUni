using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Craft!")
                {
                    break;

                }
                string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string material = tokens[1];

                if (command == "Collect")
                {
                    bool isContainingMaterial = list.Contains(material);
                    if (isContainingMaterial == false)
                    {
                        list.Add(material);
                    }
                }
                else if (command == "Drop")
                {
                    list.Remove(material);

                }
                else if (command == "Combine Items")
                {
                    string[] splitted = material.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = splitted[0];
                    string newItem = splitted[1];

                    bool isItemThere = list.Contains(oldItem);

                    if (isItemThere == true)
                    {
                        int oldItemIndex = list.IndexOf(oldItem);
                        list.Insert(oldItemIndex + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    bool isExisting = list.Contains(material);
                    string copyOfMaterial = material;
                    if (isExisting == true)
                    {
                    list.Remove(material);
                    list.Add(copyOfMaterial);

                    }

                }
            }
            Console.WriteLine(String.Join(", ", list));
        }
    }
}
