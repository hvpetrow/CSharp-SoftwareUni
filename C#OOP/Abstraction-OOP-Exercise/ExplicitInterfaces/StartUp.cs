using System;

namespace ExplicitInterfaces
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }

                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                string country = parts[1];
                int age = int.Parse(parts[2]);

                Citizen citizen = new Citizen(name,country,age);
                Console.WriteLine(citizen);             
            }
        }
    }
}
