using System;
using System.IO;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("secondTaskInput.txt");

            for (int i = 0; i < line.Length; i++)
            {
                string currLine = line[i];
                int letterCount = CountOfLetters(currLine);
                int punctMarks = CountOfMarks(currLine);
                line[i] = $"Line {i}: {currLine}({letterCount})({punctMarks})";
                File.WriteAllLines("secondTaskOutput.txt",line);
            }

        }

        private static int CountOfMarks(string currLine)
        {
            int counterOfCharacters = 0;

            foreach (char ch in currLine)
            {
                if (ch == '-' || ch == ',' || ch == '.' || ch == '!' ||ch == '?')
                {
                counterOfCharacters++;

                }
            }

            return counterOfCharacters;
        }

        private static int CountOfLetters(string currLine)
        {
            int counterOfCharacters = 0;

            foreach (char  ch in currLine)
            {
                if (char.IsPunctuation(ch)||ch==' '|| ch == '-' || ch == ',' || ch == '.' || ch == '!' || ch == '?')
                {
                    continue;
                }
                counterOfCharacters++;
                
            }

            return counterOfCharacters;
        }
    }
}
