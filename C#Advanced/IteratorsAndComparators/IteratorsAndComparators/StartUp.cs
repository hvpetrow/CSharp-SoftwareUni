using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book("Animal Farm", 2003, "George Orwell", "L.J"),
                new Book("Harry Potter", 1997, "Dorothy Sayers", "Robert Eustace"),
                new Book("1984", 1949, "George Orwell", "L.J"),
                new Book("The Documents in the Case", 1997, "George Orwell", "L.J")
            };

            books.Sort(new BookComparator());

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            //var library = new Library();

            //library.Add(new Book("Animal Farm", 2003, new List<string>(){ "George Orwell" }));
            //library.Add(new Book("Harry Potter", 1997, new List<string>(){"Dorothy Sayers", "Robert Eustace"}));
            //library.Add(new Book("1984", 2003, new List<string>(){ "George Orwell" }));
            //library.Add(new Book("The Documents in the Case", 1930, new List<string>()));
             
            //foreach (var book in library)
            //{
            //    Console.WriteLine(book);
            //}
        }
    }
}
