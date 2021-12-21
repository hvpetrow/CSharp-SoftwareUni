using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
   public class ArrayCreator <T>
    {
       public static T[] Create(int length, T item)
        {
            var arrGeneric = new T[length];
            for (int i = 0; i < length; i++)
            {
                arrGeneric[i] = item;
            }

            return arrGeneric;
        }
    }
}
