using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playlist = new Queue<string>(input);

            while (playlist.Count>0)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];
               
                if (command == "Play")
                {
                    playlist.Dequeue();
                }
                else if (command== "Add")
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 1; i < line.Length; i++)
                    {
                        if (i==line.Length-1)
                        {
                            sb.Append(line[i]);
                            continue;
                        }

                        sb.Append(line[i] + " ");

                            
                    }

                    if (playlist.Contains(sb.ToString()))
                    {
                        Console.WriteLine($"{sb.ToString()} is already contained!");
                        continue;
                    }

                    playlist.Enqueue(sb.ToString());
                }
                else if ( command=="Show")
                {
                    Console.WriteLine(String.Join(", " , playlist));
                }
            }

            Console.WriteLine("No more songs!");

        }
    }
}
