using System;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                  .Split(" " , StringSplitOptions.RemoveEmptyEntries);

            int rotationsNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < rotationsNumber; j++)
            {
                string firstElement = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];

                }
                array[array.Length - 1] = firstElement;

            }

            foreach (var element in array)
            {
                Console.Write($"{element} ");

            }
            Console.WriteLine();

        }
    }
}
