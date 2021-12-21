using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam_28June2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<int, string> bombs = new Dictionary<int, string>();
            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;
            bool bombPouch = false;
            int decrease = 0;

            while (effects.Any() && casings.Any())
            {
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    bombPouch = true;
                    break;
                }

                int peeksSum = effects.Peek() + casings.Peek()-decrease;

                if (peeksSum == 40)
                {
                    daturaBombs++;
                    effects.Dequeue();
                    casings.Pop();
                    decrease = 0;
                }
                else if (peeksSum == 60)
                {
                    cherryBombs++;
                    effects.Dequeue();
                    casings.Pop();
                    decrease = 0;
                }
                else if (peeksSum == 120)
                {
                    smokeDecoyBombs++;
                    effects.Dequeue();
                    casings.Pop();
                    decrease = 0;
                }
                else
                {
                    decrease +=5;
                    //casings.Push(casings.Pop() - 5);
                }             
            }

            if (bombPouch == true)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (!effects.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ", effects)}");
            }
            if (!casings.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ", casings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
