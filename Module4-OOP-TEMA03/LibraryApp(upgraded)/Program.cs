using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;

namespace LibraryApp_upgraded_
{
    class Program
    {
        static void Main()
        {
            var book1 = new Book("TITLE I",100,"SF");
            book1.AddAuthor(new Author("Author1", "aaa@aaa"));
            book1.AddAuthor(new Author("Author2", "bbb-bbb"));
            var book2 = new Book("TITLE II", 120, "Drama");
            book2.AddAuthor(new Author("Author3","ccc@ccc"));
            book2.AddAuthor(new Author("Author4", "ddd@ddd"));
            book2.AddAuthor(new Author("Author5", "eee@eee"));
            var book3 = new Book("TITLE III", 85, "Mystery");
            book3.AddAuthor(new Author("Author6", "fff@fff"));
            book3.AddAuthor(new Author("Author7", "ggg@ggg"));
            book3.AddAuthor(new Author("Author7", "ggg@ggg"));//dublat autorul (nu functioneaza instr. def. in AddAuthor() - de ce?
            var book4 = new Book("TITLE IV", 185, "Romance");
            book4.AddAuthor(new Author("Author8", "hhh@hhh"));
            book4.AddAuthor(new Author("Author9", "iii@iii"));
            var book5 = new Book("TITLE V", 138, "SF");
            book5.AddAuthor(new Author("Author3", "ccc@ccc"));
            book5.AddAuthor(new Author("Author5", "eee@eee"));
            book5.AddAuthor(new Author("Author8", "hhh@hhh"));


            var library1 = new Library("LIBRARY I");
            library1.AddBook(book1);
            library1.AddBook(book2);
            var library2 = new Library("LIBRARY II");
            library2.AddBook(book3);
            library2.AddBook(book3);//dublata cartea (aici functioneaza instr. def. in AddBook())
            library2.AddBook(book4);
            library2.AddBook(book5);

            library1.Print();
            library2.Print();

            library2.RemoveBook(book4);

            Console.WriteLine("\n\t After 'TITLE IV' removal from 'LIBRARY II': ");
            library1.Print();
            library2.Print();

            Console.ReadLine();
        }
    }
}
