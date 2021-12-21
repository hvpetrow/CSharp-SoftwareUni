using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            Password(command);



        }
        static void Password(string command)
        {
            bool allChar = false;
            bool hasTwoDigits = false;
            bool onlyDigitsAndLetters = true;

            if (command.Length >= 6 && command.Length<= 10)
            {
                allChar = true;
            }
            for (int i = 0; i < command.Length; i++)
            {
                int digitsCounter = 0;
                int currentAsciiChar = i;
                char currenChar = (char)i;
              

               
                if (currentAsciiChar >= 48 && currentAsciiChar <= 57)
                {
                    digitsCounter++;
                    if (digitsCounter >= 2)
                    {
                        hasTwoDigits = true;
                    }
                
                }

                if (!(currentAsciiChar >= 48 && currentAsciiChar <= 57) && (currentAsciiChar >= 97 && currentAsciiChar <= 122))
                {
                    onlyDigitsAndLetters = false;
                }
              

            }
            if (!allChar)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (onlyDigitsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
           

            if (allChar && hasTwoDigits && !onlyDigitsAndLetters)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
