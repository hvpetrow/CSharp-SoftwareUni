using System;
using System.Linq;
using System.Numerics;

namespace _02.ShootfortheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargets = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;

                }
                int index = int.Parse(input);

                if (index>sequence.Length-1)
                {
                    continue;
                }
                else if (index<0)
                {
                    continue;
                }
              
                int currentShottedTartget = sequence[index];

                if (currentShottedTartget==-1)
                {
                    continue;
                }
                else
                {
                sequence[index] = -1;
                    shotTargets++;
                }
                
                for (int i = 0; i < sequence.Length; i++)
                {
                    int currentTarget = sequence[i];
                    if (currentTarget==-1)
                    {
                        continue;
                    }
                    else
                    {
                        if (currentTarget>currentShottedTartget)
                        {
                            sequence[i] -= currentShottedTartget;
                        }
                        else
                        {
                            sequence[i] += currentShottedTartget;
                        }
                    }
                }
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> " + String.Join(" " , sequence));          
        }
    }
}
