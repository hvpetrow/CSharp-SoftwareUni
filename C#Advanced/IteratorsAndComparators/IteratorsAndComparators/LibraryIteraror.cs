using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class LibraryIteraror : IEnumerator<Book>
    {
        List<Book> books;
        private int index;

        public LibraryIteraror(List<Book> books)
        {
            this.books = books;
            index = -1;
        }


        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return index < books.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
