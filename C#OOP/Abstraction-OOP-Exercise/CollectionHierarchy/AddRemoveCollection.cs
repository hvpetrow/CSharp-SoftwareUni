using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
   public class AddRemoveCollection
    {

        private List<string> elements;
        public AddRemoveCollection()
        {
            elements = new List<string>();
        }
        public int Add(string element)
        {
            elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string removedElement = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return removedElement;
        }
    }
}
