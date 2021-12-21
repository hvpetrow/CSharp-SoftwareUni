using System;
using System.Linq;

namespace _07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> predicate = (x, n) => x.Length <= n;
            Action<string[]> print = x => Console.WriteLine(String.Join(Environment.NewLine , x ));

            string[] filtered = names.Where(x => predicate(x, n)).ToArray();
            print(filtered);
        }
    }
}
