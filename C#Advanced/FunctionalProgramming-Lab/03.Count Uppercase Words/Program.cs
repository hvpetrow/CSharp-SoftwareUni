using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split( ' ' , StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> func = x => char.IsUpper(x[0]);
            var output = words.Where(func);

            foreach (var word in output)
            {
                Console.WriteLine(word);
            }

        }
    }
}
