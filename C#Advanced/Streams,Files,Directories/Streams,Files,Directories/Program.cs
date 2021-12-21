using System;
using System.IO;


namespace Streams_Files_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"countries.txt.txt");
            using StreamWriter sw = new StreamWriter(@"countriesLinesNumber.txt");

            var rowNumber = 0;
                                                                                            
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                    sw.WriteLine($"{line}");
                

                rowNumber++;
            }



        }
    }
}
