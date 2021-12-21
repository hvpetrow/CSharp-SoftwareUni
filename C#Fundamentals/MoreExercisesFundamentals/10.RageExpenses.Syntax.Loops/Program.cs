using System;

namespace _10.RageExpenses.Syntax.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());

            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsetCount = 0;
            int trashedMouseCount = 0;
            int trashedKeyboardtCount = 0;
            int trashedDisplayCount = 0;

                int cell = 1;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                cell = i;
                if (cell%2==0)
                {
                    trashedHeadsetCount++;
                }
                if (cell%3 ==0)
                {
                    trashedMouseCount++;
                }
                if (cell%6 == 0)
                {
                    trashedKeyboardtCount++;
                }
                if (cell%12==0)
                {
                    trashedDisplayCount++;
                }
            }
            headsetPrice *= trashedHeadsetCount;
            mousePrice *= trashedMouseCount;
            keyboardPrice *= trashedKeyboardtCount;

            displayPrice *= trashedDisplayCount;
            
            double totalPrice = headsetPrice + mousePrice + keyboardPrice + displayPrice;
            ;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
