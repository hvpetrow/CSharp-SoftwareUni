using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryPath = @"C:\Users\HP\source\repos\Streams,Files,Directories\ConsoleApp2\bin\Debug\netcoreapp3.1";
            string[] files = Directory.GetFiles(directoryPath);

            long totalLegth = 0;

            foreach (var file in files)
            {
                totalLegth += new FileInfo(file).Length;


            }

            Console.WriteLine(totalLegth);
        }
    }
}
