using System;

namespace FundamentalsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line=="Sign up")
                {
                    break;
                }

                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command=="Case")
                {
                    string doing = parts[1];

                    if (doing=="upper")
                    {
                        text = text.ToUpper();
                    }
                    else
                    {
                        text = text.ToLower();
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    if ((startIndex<0 )||(startIndex>text.Length) || (endIndex>text.Length) || (endIndex<0))
                    {
                        continue;
                    }
                    string oldSubrstring = text.Substring(startIndex, endIndex);
                    string reversed = string.Empty;

                    for (int i = oldSubrstring.Length - 1; i >= 0; i--)
                    {
                        reversed += oldSubrstring[i];
                    }

                    Console.WriteLine(reversed);
                }
                else if (command == "Cut")
                {
                    string substr = parts[1];

                    if (text.Contains(substr))
                    {
                        int idx = text.IndexOf(substr);
                        text =text.Remove(idx, substr.Length);
                    }
                    else
                    {
                        Console.WriteLine($"The word {text} doesn't contain {substr}.");
                        continue;
                    }
                    Console.WriteLine(text);
                }
                else if (command =="Replace")
                {
                    string a = parts[1];
                    string rep = "*";
                    text = text.Replace(a, rep);
                    Console.WriteLine(text);
                }
                else if (command == "Check")
                {
                    string checker = parts[1];

                    if (text.Contains(checker))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {checker}.");
                    }
                    int a =
                    int t = ++5; 
                }
            }
        }
    }
}
