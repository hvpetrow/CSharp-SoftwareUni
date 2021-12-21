using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIt
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        List<T> list = new List<T>();
        int index;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public bool Move()
        {
            for (int i = index; i < list.Count; i++)
            {
                if (i + 1 < list.Count)
                {
                    index++;
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
        }

        public void Print()
        {
            if (!list.Any())
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }

        public bool HasNext()
        {
            for (int i = index; i < list.Count; i++)
            {
                if (i + 1 < list.Count)
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
