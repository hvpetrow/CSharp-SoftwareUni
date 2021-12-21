using System;

namespace _04.Printandsum.ConditionalSyntax.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() ;
            int counter = 0;
            int counter2 = 1;

            for (int i = 0; i < 4 ; i++)
            {
            string reversed = string.Empty;
                string password = Console.ReadLine();
              
                for (int j =input.Length-1 ; j >= 0; j--)
                {
                    char currenChar = input[j];
                    reversed += currenChar;
                }
                if (reversed==password)
                {
                    Console.WriteLine($"User {input} logged in.");
                    return;
                }
                else
                {
                    counter2++;
                    if (counter2==5)
                    {
                        Console.WriteLine($"User {input} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }
               
           
            
          
        }
    }
}
