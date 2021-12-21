using System;

namespace beforeFundExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Reveal")
                {
                    break;
                }

                string[] parts = input.Split(":|:",StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command== "InsertSpace")
                {
                    int index = int.Parse(parts[1]);
                    if (index<0 ||index> message.Length)
                    {
                        continue;
                    }

                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substr = parts[1];

                    if (message.Contains(substr))
                    {
                        int substringIndex = message.IndexOf(substr);
                       message= message.Remove(substringIndex, substr.Length);

                      
                        string reversed = string.Empty;
                        for (int i = substr.Length - 1; i >= 0; i--)
                        {
                            reversed += substr[i];
                        }
                        message += reversed;
                        Console.WriteLine(message);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                    
                }  
                else if (command=="ChangeAll")
                {
                    string substring = parts[1];
                    string replacement = parts[2];

                   
                        message = message.Replace(substring, replacement);
                    
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
