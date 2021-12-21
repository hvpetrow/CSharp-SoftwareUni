using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
              .Split()          
               .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="3:1")
                {
                    break; 

                }
                string[] line = input.Split();
                string command = line[0];
                int startIndex = int.Parse(line[1]);
                

                if (command=="merge")
                {
                   
                string newWord = string.Empty;
        
                    int endIndex = int.Parse(line[2]);

                    if (startIndex < 0)
                    {
                        if (endIndex<list.Count)
                        {

                        startIndex = 0; 
                        
                        
                         }
                    if (endIndex > list.Count - 1)
                    {
                        if (startIndex>=0 && startIndex<=list.Count-1)
                        {

                        endIndex = list.Count - 1;
                        }
                    }
                    if ((startIndex >= 0 && startIndex <= list.Count - 1) && endIndex >= 0 && endIndex <= list.Count - 1)
                    {

                    

                    for (int i =startIndex; i <= endIndex; i++)
                    {
                        newWord += list[i];
                    }
                  
                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                        list.Insert(startIndex, newWord);
                    }
                }
            }
                Console.WriteLine(string.Join(" " , list));
        }
    }
}
