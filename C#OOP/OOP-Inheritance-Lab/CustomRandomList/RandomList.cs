using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
   public class RandomList:List<string>
    {
        Random random;

        public RandomList()
        {
            random = new Random();
        }
        public string RandomString()
        {
            var index =random.Next(0,Count);
            string element = this[index];
            Remove(element);
            return element;
        }
    }
}
