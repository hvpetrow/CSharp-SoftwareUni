using System;

namespace PadawanEquipment
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double moneyBalance = double.Parse(Console.ReadLine());
            int countStudent = int.Parse(Console.ReadLine());
            double priceLightSaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            double totalLightSabersPrice = Math.Ceiling(countStudent + 0.1 * countStudent) * priceLightSaber;
            double totalRobesPrice = countStudent * priceRobe;
            double totalBeltPrice = countStudent * priceBelt;

            int freeBelt = (countStudent / 6);

            double totalPriceOfAll = totalLightSabersPrice + totalRobesPrice + (totalBeltPrice - (freeBelt * priceBelt));

            if (moneyBalance >= totalPriceOfAll)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPriceOfAll:f2}lv.");

            }

            else if (moneyBalance < totalPriceOfAll)
            {
                Console.WriteLine($"John will need {totalPriceOfAll - moneyBalance:f2}lv more.");
            }

        }
    }
}

