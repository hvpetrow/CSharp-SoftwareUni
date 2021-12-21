using System;
using System.Linq;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> namesAppender = name=>Console.WriteLine("Sir " + name);
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(namesAppender);
        }
    }
}
