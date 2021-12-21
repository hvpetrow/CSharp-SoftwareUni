using System;
using System.Text;

namespace _04.ProgrammingFundamentalsFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
                    StringBuilder sb = new StringBuilder(text);
                    StringBuilder newSb = new StringBuilder(text);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "TakeOdd")
                {

                    for (int i = 1; i < text.Length; i+=2)
                    {
                       
                            sb.Append(text[i]);
                      
                    }
                    Console.WriteLine(sb);
                }

                else if (command == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);

                    sb.Remove(index, length);

                    Console.WriteLine(sb);
                }
                else if (command == "Substitute")
                {
                    string substring = tokens[1];
                    string substitute = tokens[2];

                    if (!sb.ToString().Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        sb.Replace(substring, substitute);
                        Console.WriteLine(sb);
                    }
                }
            }

            Console.WriteLine($"Your password is: {sb}");
        }
    }
}
