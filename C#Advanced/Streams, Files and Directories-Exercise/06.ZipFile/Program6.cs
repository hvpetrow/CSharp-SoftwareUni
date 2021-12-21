using System;
using System.IO.Compression;

namespace _06.ZipFilee
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\HP\Pictures\Saved Pictures", @"C:\TestSoftUni\test.zip");
            ZipFile.ExtractToDirectory(@"C:\TestSoftUni\test.zip", @"C:\TestSoftUni");




        }
    }
}
