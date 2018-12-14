using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Library
    {
        private List<Book> lstBooks = new List<Book>();
        //private List<Author> lstAuthors = new List<Author>();

        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library() { }

        public Library(string name, List<Book> listOfBooks)
        {
            this.Name = name;
            this.Books = listOfBooks;
        }

        public Library AddLibrary()
        {
            Console.WriteLine("\t Name of library: ");
            string nameOfLibrary = Console.ReadLine();

            this.Name = nameOfLibrary;

            Console.WriteLine("\t Number of books to add: ");
            int noOfBooks = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfBooks; i++)
            {
                lstBooks.Add(this.AddBook());
            }
            this.Books = lstBooks;
            var newLibr = new Library(this.Name, this.Books);
            return newLibr;
        }
        public Book AddBook()
        {
            Console.WriteLine("\t Title of book: ");
            string titleOfBook = Console.ReadLine();

            Console.WriteLine("\t Price of book: ");
            decimal priceOfBook = Convert.ToDecimal(Console.ReadLine ());

            Console.WriteLine("\t Genre of book: ");
            string genreOfBook = Console.ReadLine();

            Console.WriteLine("\t Number of authors to add: ");
            int nrOfAuth = Convert.ToInt32(Console.ReadLine());

            var book = new Book();
            var listOfAuth = new List<Author>();
            for (int i = 0; i < nrOfAuth; i++)
            {
                listOfAuth.Add(book.AddAuthor());
            }

            var newBook = new Book(titleOfBook,priceOfBook,genreOfBook,listOfAuth);

            return newBook;
        }
        public void RemoveBook()
        {
            Console.WriteLine($"\n\t Enter the title of the book you want to delete: ");
            string titleToDelete = Console.ReadLine();

            foreach (var book in lstBooks.ToList())
            {
                if (titleToDelete == book.Title)
                {
                    lstBooks.Remove(book);
                }
            }
            this.Books = lstBooks;
        }
        public void Print()
        {
            Console.WriteLine($"\n\t Library name: '{this.Name}'");
            foreach (var book in this.Books)
            {
                book.Print();
            }
        }
    }
}
