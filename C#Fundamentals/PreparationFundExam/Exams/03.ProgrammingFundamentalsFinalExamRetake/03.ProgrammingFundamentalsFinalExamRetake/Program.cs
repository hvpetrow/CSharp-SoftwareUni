using System;
using System.Text;
using System.Linq;

namespace _03.ProgrammingFundamentalsFinalExamRetake
{
    class Program
    {
        static void Main(string[] args)
        {

            string meessage = Console.ReadLine();
            StringBuilder sb = new StringBuilder(meessage);

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Reveal")
                {
                    break;
                }

                string[] parts = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command=="InsertSpace")
                {
                    int index = int.Parse(parts[1]);
                    if (index>sb.Length-1 || index<0)
                    {
                        continue;
                    }
                    string space = " ";
                    sb.Insert(index, space);

                    Console.WriteLine(sb);
                }
                else if (command=="Reverse")
                {
                    string substring = parts[1];
                    string oldSubstring = substring;
                    string empty = string.Empty;

                    if (sb.ToString().Contains(oldSubstring))
                    {
                        sb.Replace(oldSubstring,empty);
                        string reversedSubstring = string.Empty;

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversedSubstring += substring[i];
                        }

                    sb.Append(reversedSubstring);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                Console.WriteLine(sb);
                }

                else if (command=="ChangeAll")
                {
                    string substr = parts[1];
                    string replacement = parts[2];

                    while (sb.ToString().Contains(substr))
                    {
                    sb.Replace(substr, replacement);

                    }
                    Console.WriteLine(sb);
                }
            }
            Console.WriteLine($"You have a new text message: {sb}");
        }
    }
}
