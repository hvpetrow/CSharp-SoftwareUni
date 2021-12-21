using System;
using System.Linq;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" " , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                

                if (command == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    int firstElement = array[firstIndex];
                    int secondElement = array[secondIndex];

                    array[firstIndex] = secondElement;
                    array[secondIndex] = firstElement;
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    int firstElement = array[firstIndex];
                    int secondElement = array[secondIndex];

                    array[firstIndex] = firstElement * secondElement;
                }
                else if (command=="decrease")
                {
                    for (int i = 0; i <= array.Length-1; i++)
                    {
                        array[i] =array[i] -  1;

                    }
                }
            }
            Console.WriteLine(String.Join(", " , array));
        }   
    }
}
