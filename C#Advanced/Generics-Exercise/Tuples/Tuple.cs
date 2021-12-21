using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
   public class Tuple<Item1,Item2,Item3>
    {
        public Tuple(Item1 firstItem , Item2 secondItem , Item3 thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public Item1 FirstItem{ get; set; }

        public Item2 SecondItem { get; set; }

        public Item3 ThirdItem { get; set; }

        public string PrintIt()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
