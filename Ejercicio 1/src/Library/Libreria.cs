using System.Collections.Generic;
using System;

namespace SRP
{
    public class Bookshelf
    {
        public List<Book> Libros = new List<Book>();
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Bookshelf(String librarysector, String libraryshelve)
        {
            this.LibrarySector = librarysector;
            this.LibraryShelve = libraryshelve;
        }

        public void ShelveBook(Book libro)
        {
            this.Libros.Add(libro);
        }

    }
}