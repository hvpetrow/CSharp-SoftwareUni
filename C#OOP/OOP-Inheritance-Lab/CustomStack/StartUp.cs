using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>{"1","2","3" };
            var myStack = new StackOfStrings();
            Console.WriteLine(myStack.IsEmpty());
            myStack.AddRange(list);
            Console.WriteLine(myStack.IsEmpty());
        }
    }
}
