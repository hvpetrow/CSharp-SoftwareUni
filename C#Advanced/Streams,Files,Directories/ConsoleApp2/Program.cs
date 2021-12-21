using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string fileContent = File.ReadAllText("oddCountries.txt");
            // string[] fileContentArray = File.ReadAllLines("countries.txt");
            // File.WriteAllText("all.txt","Hristo");
            string[] write = new string[] { "asd", "123", "455678"};
            File.AppendAllText("write.txt" , "NEWWLiN");

        }
    }
}
