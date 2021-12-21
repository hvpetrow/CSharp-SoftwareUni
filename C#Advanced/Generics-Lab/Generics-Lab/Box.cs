using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
  public  class Box<T>
    {
        private List<T> listBox = new List<T>();
        public int Count => listBox.Count;

       public void Add(T a)
        {
            listBox.Add(a);
        }

        public T Remove()
        {
            T element = listBox[listBox.Count - 1];
            listBox.RemoveAt(listBox.Count - 1);
            return element;
        }
    }
}
