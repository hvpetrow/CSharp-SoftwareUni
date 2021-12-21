using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string name =  Console.ReadLine() .ToLower() ;
            Console.WriteLine(SumOfVowels(name));

        }


        static int SumOfVowels(string command)
        {
            int sum = 0;
            for (int i =0; i < command.Length; i++)
            {
                char currentChar = command[i];
                if (currentChar == 'a' || currentChar == 'o'|| currentChar == 'u' || currentChar == 'e' || currentChar == 'i')
                {
                    sum++;
                }
            }
            return sum;
        
        }
    }
}
