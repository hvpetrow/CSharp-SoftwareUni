using System;
using System.Text;

namespace _05.FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            StringBuilder sb = new StringBuilder(key);
         

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Generate")
                {
                    break;
                }

                string[] tokens = input.Split(">>>" , StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command=="Contains")
                {
                    string substring = tokens[1];

                    if (sb.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{sb} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command=="Flip")
                {

                    string secondaryCommand = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                   
                    if (secondaryCommand=="Upper")
                    {
                        int cuttedIndex = endIndex - startIndex;
                        string oldSubstring = sb.ToString().Substring(startIndex, cuttedIndex);
                        string toUpper = sb.ToString().Substring(startIndex, cuttedIndex).ToUpper();
                        sb.Replace(oldSubstring, toUpper);
                        Console.WriteLine(sb);
                        
                    }
                    else if (secondaryCommand=="Lower")
                    {
                        int cuttedIndex = endIndex - startIndex;

                        string oldSubstring = sb.ToString().Substring(startIndex,cuttedIndex );
                        string toUpper = sb.ToString().Substring(startIndex, cuttedIndex).ToLower();
                        sb.Replace(oldSubstring, toUpper);
                    Console.WriteLine(sb);
                    }
                }
                else if (command== "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int length = endIndex - startIndex;
                    sb.Remove(startIndex, length);
                    Console.WriteLine(sb);
                }
            }

            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
