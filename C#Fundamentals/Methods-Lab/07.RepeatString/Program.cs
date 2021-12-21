using System;
using System.Linq;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = String(a, n); 

            Console.Write(result);

        }
        static string String( string abc, int n)
        {
            StringBuilder end = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                end.Append(abc);
            }
            return end.ToString(); 

        }


    }
}
