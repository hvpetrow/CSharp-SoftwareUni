using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> 
    where T : IComparable<T>
    {
        
        private T data;
        private List<T> list;

        public Box(T value)
        {
         list = new List<T>();
            data = value;
        }
        public void Add(T element)
        {
            list.Add(element);  
        }
        public void Swap(int firstIndex , int secondIndex)
        { 
           T item = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = item;
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data} ";
        }

        public int CompareTo(T other)
        {
            return data.CompareTo(other);
        }

    }
}
