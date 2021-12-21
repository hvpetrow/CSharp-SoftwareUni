using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                string input = Console.ReadLine();
                if (input== "end"  )
                {
                    break;

                }
                string[] line = input.Split();
                if (line[0] == "Contains")
                {
                    int currentNumber = int.Parse(line[1]);
                    if (numbers.Contains(currentNumber))
                    {
                        Console.WriteLine("Yes");

                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (line[0]=="PrintEven")
                {
                 
                    foreach (var number in numbers)
                    {
                        if (number%2==0)
                        {
                            Console.Write($"{number} ");
                        }
                        

                     }
                    

                }
                else if (line[0] == "PrintOdd")
                {
                   
                    foreach (var number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write($"{number } ");
                           
                        }

                    }

                }
                else if (line[0] == "GetSum")
                {
                  
                        int sum = 0;
                    foreach (var number in numbers)
                    {
                        sum += number;

                    }
                        Console.WriteLine(sum);

                }
                else if (line[0] == "Filter")
                {
                    int currentNumber = int.Parse(line[2]);
                    if (line[1]==">=")
                    {
                        numbers.RemoveAll (n => n < currentNumber) ;
                        Console.WriteLine(String.Join(" ", numbers));
                    }
                    else if (line[1] == ">")
                    {
                        numbers.RemoveAll(n => n <= currentNumber);
                        Console.WriteLine(String.Join(" ", numbers));
                    }
                    else if (line[1] == "<=")
                    {
                        numbers.RemoveAll(n => n > currentNumber);
                        Console.WriteLine(String.Join(" ", numbers));
                    }
                    else if (line[1] == "<")
                    {
                        numbers.RemoveAll(n => n >= currentNumber);
                        Console.WriteLine(String.Join(" ", numbers));
                    }
                }
            }
          
        }
    }
}
