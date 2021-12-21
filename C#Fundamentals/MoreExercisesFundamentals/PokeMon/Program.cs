using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            decimal origValue = n*0.50M;
            while (n>=m)
            {
                n -= m;
                count+=1;
                if (n==origValue)
                {
                    if (y==0)
                    {
                        continue;                
                    }
                    else
                    {
                        n = (int)n / y;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
