using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();


            foreach (var item in input)
            {

                if (stack.Any())
                {
                char peek = stack.Peek();
                    if (item==']' && peek == '[')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (item==')' && peek =='(')
                    {
                        stack.Pop();
                        continue;

                    }
                    else if (item=='}' && peek == '{')
                    {
                        stack.Pop();
                        continue;

                    }
                }
               
                    stack.Push(item);        
            }

            Console.WriteLine(!stack.Any()? "Yes" : "No");
        }
    }
}
