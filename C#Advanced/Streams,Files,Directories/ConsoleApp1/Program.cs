using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fileStream = new FileStream("countries.txt", FileMode.OpenOrCreate);
            var data = new byte[fileStream.Length];


            var bytesPerFile = (int)Math.Ceiling(data.Length / 4.0);

            for (int i = 1; i <= 4; i++)
            {
                var buffer = new byte[bytesPerFile];
                fileStream.Read(buffer);

                using FileStream writer = new FileStream($"Part-{i}.txt", FileMode.OpenOrCreate);
                writer.Write(buffer);
            }

        }
    }
}
