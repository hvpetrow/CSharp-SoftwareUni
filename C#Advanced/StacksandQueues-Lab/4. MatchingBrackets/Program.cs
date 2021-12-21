using System;
using System.Collections.Generic;

namespace _4._MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i]==')')
                {
                    int openedBracketIndex = indexes.Pop();
                    int closedBracketIndex = i;

                Console.WriteLine(input.Substring(openedBracketIndex , closedBracketIndex-openedBracketIndex+1));
                }
            }

        }
    }
}
