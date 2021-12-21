using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MatrixN(num);

        }
        static void MatrixN(int num)
        {
           
           for (int column = 0; column < num; column++)
            {
              for (int rows = 0; rows <num; rows++)
                    {
                            Console.Write(num + " ");
               }
                Console.WriteLine();
            }
           
        }
    }
}
