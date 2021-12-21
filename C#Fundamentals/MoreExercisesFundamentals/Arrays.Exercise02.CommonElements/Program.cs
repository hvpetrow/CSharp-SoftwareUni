using System;

namespace Arrays.Exercise02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries);

            string[] text2 = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < text2.Length; i++)
            {
                string currentElement = text2[i];
                for (int l = 0; l < text.Length; l++)
                {
                    if (currentElement == text[l])
                    {
                        Console.Write(currentElement+ " ");
                    }
                }
               
            }

        }
    }
}
