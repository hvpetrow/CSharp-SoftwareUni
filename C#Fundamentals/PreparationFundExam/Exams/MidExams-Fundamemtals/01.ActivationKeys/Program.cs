using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Generate")
                {
                    break;
                }
                string[] tokens = line.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string newMade = string.Empty;
                if (command=="Contains")
                {
                    string substring = tokens[1];
                    for (int i = 0; i < input.Length; i+=substring.Length)
                    {
                        for (int j = 0; j < substring.Length; j++)
                        {
                            char current = input[j];
                            newMade += current;
                        }
                    }
                        if (substring==newMade)
                        {
                            Console.WriteLine($"{input} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                }
                else if (command=="Flip")
                {
                    string secondCommand = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    string newWord = string.Empty;
                    if (secondCommand=="Upper")
                    {
                    string changedSubstring = input.Substring(startIndex, endIndex).ToUpper();
                        string firstPart = input.Substring(0, startIndex);
                        string secondPArt = input.Substring(endIndex);
                        newWord += firstPart;
                        newWord += changedSubstring;
                        newWord += secondPArt;
                        input = newWord;
                        Console.WriteLine(input);
                    }
                    else if (secondCommand=="Lower")
                    {
                    string changedSubstring = input.Substring(startIndex, endIndex).ToLower();
                        string firstPart = input.Substring(0, startIndex);
                        string secondPArt = input.Substring(endIndex);
                        newWord += firstPart;
                        newWord += changedSubstring;
                        newWord += secondPArt;
                        input = newWord;
                        Console.WriteLine(input);
                    }



                }
                else if (command=="Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    input = input.Remove(startIndex+2 ,endIndex );
                    Console.WriteLine(input);
                }
            }
        Console.WriteLine(input);
        }
    }
}
