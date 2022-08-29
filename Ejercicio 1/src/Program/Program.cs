using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Bookshelf libreria1 = new Bookshelf("A", "7");
            
            libreria1.ShelveBook(book1);
            Console.WriteLine($"La libreria {libreria1.LibraryShelve} en el sector {libreria1.LibrarySector} contiene los libros:");
            foreach(Book el in libreria1.Libros)
            {
                Console.WriteLine(el.Title);
            }

            /*OLD
            book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");
            */
        }
    }
}