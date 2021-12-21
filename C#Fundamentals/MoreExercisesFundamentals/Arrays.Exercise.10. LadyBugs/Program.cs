using System;
using System.Linq;

namespace Arrays.Exercise._10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            int[] fieldArr = new int[size];
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for ( int k = 0; k < input.Length; k++)
            {
                input[k] = 1;
            }

            for (int  i  = 0;  i  <input.Length;  i ++)
            {
                fieldArr[i] = input[i]; 
 
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end")
                {
                    break;

                }
                string[] command = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int startIndex = int.Parse(command[0]);
                string direction = command[1];
                int endIndex = int.Parse(command[2]);

                if (direction=="right")
                {
                    if (endIndex > fieldArr.Length - 1)
                    {
                        fieldArr[startIndex] = 0;                   
                        break;
                    }
                    for (int i = startIndex; i < fieldArr.Length ; i++)
                    {
                        if (fieldArr[i] == 0)
                        {
                            fieldArr[startIndex] = 0;
                            fieldArr[i] = 1;
                            break;

                        }
                        else if (fieldArr[i] == 1)
                        {
                            fieldArr[startIndex] = 0;
                            continue;
                        }
                    }
                }
                else if (direction=="left")
                {
                    if (endIndex<0)
                    {
                        fieldArr[startIndex] = 0;
                        break;
                    }
                    for (int i = fieldArr.Length-1; i >= 0; i--)
                    {
                        if (fieldArr[i] == 0)
                        {
                            fieldArr[startIndex] = 0;
                            fieldArr[i] = 1;
                            break;

                        }
                        else if (fieldArr[i] == 1)
                        {
                            fieldArr[startIndex] = 0;
                            continue;
                        }
                    }
                }
            }
            foreach (var ladyBug in fieldArr)
            {



                Console.Write($"{ladyBug } ");
            }
        }
    }
}
