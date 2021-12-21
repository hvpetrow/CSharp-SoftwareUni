using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] namesCollection = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> function = (name, n) =>
            {
                int sum = 0;

                foreach (char ch in name)
                {
                    sum += ch;
                }

                if (sum>=n)
                {
                return true;

                }
                else
                {
                    return false;
                }
            };

            var filtered = namesCollection.Where(name => function(name, n)).First();

           
                Console.WriteLine(String.Join(" " , filtered));
           
        }
    }
}
