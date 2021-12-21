﻿using System;
using System.Linq;

namespace Froggy
{
   public class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);

            Console.WriteLine(String.Join(", " , lake));
        }
    }
}
