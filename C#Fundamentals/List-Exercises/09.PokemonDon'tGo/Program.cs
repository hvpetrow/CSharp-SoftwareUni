using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToList();

            int sum = 0;

            while (list.Count!=0)
            {
                int index = int.Parse(Console.ReadLine());
                int lastElement = list.Count - 1;
                if (index<0)
                {
                    int removedValue = list[lastElement];

                    sum += removedValue;
                    list.RemoveAt(0);
                    list.Insert(0, list[lastElement]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        int currentIndex = list[i];
                        if (currentIndex <= removedValue)
                        {
                            list[i] += removedValue;
                        }
                        else if (currentIndex > removedValue)
                        {
                            list[i] -= removedValue;

                        }

                    }
                    continue;
                   
                }
                if (index>lastElement)
                {
                        int removedValue = list[lastElement];
                    list.RemoveAt(lastElement);
                    sum += removedValue;
                    list.Add(list[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        int currentIndex = list[i];
                        if (currentIndex <= removedValue)
                        {
                            list[i] += removedValue;
                        }
                        else if (currentIndex > removedValue)
                        {
                            list[i] -= removedValue;

                        }

                    }
                    continue;
                }

                int removedIndexValue = list[index];

                list.RemoveAt(index);

                for (int i = 0; i < list.Count; i++)
                {
                    int currentIndex = list[i];
                    if (currentIndex<= removedIndexValue)
                    {
                    list[i] += removedIndexValue;
                    }
                   else if  (currentIndex > removedIndexValue )
                    {
                        list[i] -= removedIndexValue;

                    }

                }
                    sum += removedIndexValue;

            }
            Console.WriteLine(sum);

        }
    }
}
