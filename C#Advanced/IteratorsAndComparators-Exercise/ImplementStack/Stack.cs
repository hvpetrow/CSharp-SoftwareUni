using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementStack
{
    public class Stack<T> : IEnumerable<T>
    {
        List<T> stack;
        int count;
        public Stack(List<T> elements)
        {
            stack = elements;
            count = stack.Count;
        }

        public void Push(T element)
        {
            stack.Add(element);
            count++;
        }
        public void Pop()
        {
            if (stack.Any())
            {
            stack.RemoveAt(count-1);
                count--;
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
