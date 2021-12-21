using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
   public class Library : IEnumerable<Book>
    {
        List<Book> books;

        public Library()
        {
            books = new List<Book>();

        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIteraror(books);
             ////       OR -------->  ...   //////////
            //////for (int i = 0; i < books.Count; i++)
            ////{
            ////    yield return books[i];
            ////}
        }

        public void Remove(Book book)
        {
            books.Remove(book);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
