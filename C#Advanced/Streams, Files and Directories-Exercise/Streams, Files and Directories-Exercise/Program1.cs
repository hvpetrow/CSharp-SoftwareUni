using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams__Files_and_Directories_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader streamReader = new StreamReader(@"firstTaskRead.txt");
            using StreamWriter writer = new StreamWriter(@"firstTask.txt");
           
            int counter = 0;

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();

                if (line==null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    line = ReplaceAll(line);

                    line = Reverse(line);
                    writer.WriteLine(line);
                    Console.WriteLine(line);
                }

                counter++;

            }

        }

        private static string ReplaceAll(string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-' || line[i] == ',' || line[i] == '.' || line[i] == '!' || line[i] == '?')
                {
                    sb.Append('@').ToString();
                }
                else
                {
                    sb.Append(line[i]).ToString();
                }
            }

            return sb.ToString();
        }

        static string Reverse (string line)
        {
            StringBuilder stringB = new StringBuilder();
            string[] word = line.Split(' ').ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                stringB.Append(word[word.Length - i - 1]);
                stringB.Append(' ');
            }

            return stringB.ToString();




        }
    }
}
