using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Library
    {
        public string Name { get;}
        private List<Book> Books { get; }

        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (!this.Books.Contains(book))//aici functioneaza instructiunea
            {
                this.Books.Add(book);
            }
        }

        public void RemoveBook(Book book)
        {
            this.Books.Remove(book);
        }

        public void Print()
        {
            Console.WriteLine($"\n\t Library name: {this.Name}");
            foreach (var book in Books)
            {
                book.Print();
            }
        }
    }
}
