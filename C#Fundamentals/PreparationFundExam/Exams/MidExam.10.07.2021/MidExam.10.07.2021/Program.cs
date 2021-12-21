using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam._10._07._2021
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> parts =Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
 
            while (true)
            {

                string input = Console.ReadLine();
                if (input=="Done")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];


                if (command=="Add")
                {
                    string addThis = tokens[1];
                

                    if (index<0 || index>parts.Count-1)
                    {
                        continue;
                     }

                    parts.Insert(index, addThis);

                }

                else if (command=="Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < 0 || index > parts.Count - 1)
                    {
                        continue;
                    }
                    parts.RemoveAt(index);
                   

                }
                else if (command=="Check")
                {
                    string even = tokens[1];
                    if (even=="Even")
                    {
                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (i%2==0)
                            {
                            Console.Write(parts[i] + " ");
                            }
                         }
                                Console.WriteLine();
                    }
                    else if(even=="Odd")
                    {
                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(parts[i] + " ");
                            }
                        }
                                Console.WriteLine();
                    }
                }              
            }
            Console.WriteLine($"You crafted {String.Join("" ,parts)}!");
        }
    }
}
