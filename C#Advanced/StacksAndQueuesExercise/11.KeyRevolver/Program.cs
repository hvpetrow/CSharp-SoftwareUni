using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            int firedBullets = 0;
            int reloadingCounter = 0;
            int leftLocks = locksQueue.Count;
            int bulletCount = bulletsStack.Count;

            while (true)
            {
                int currentBullet = bulletsStack.Peek();
                int currentLock = locksQueue.Peek();

                if (currentBullet<=currentLock)
                {
                    bulletsStack.Pop();
                    locksQueue.Dequeue();

                    leftLocks--;
                    firedBullets++;
                    reloadingCounter++;
                    Console.WriteLine("Bang!");

                }
                else
                {
                    bulletsStack.Pop();
                    firedBullets++;
                    reloadingCounter++;
                    Console.WriteLine("Ping!");
                }

              
                if (locksQueue.Count==0)
                {
                   
                    break;
                }
             if (bulletsStack.Count==0)
                {
                   
                    break;
                }
                if (reloadingCounter == barrelSize && bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    reloadingCounter = 0;
                }
            }
            
          
            if(leftLocks==0)
            {
                Console.WriteLine($"{bulletCount-firedBullets} bullets left. Earned ${intelligence-(firedBullets*bulletPrice)}");
            }
           else if (bulletsStack.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {leftLocks}");
            }




        }
    }
}
