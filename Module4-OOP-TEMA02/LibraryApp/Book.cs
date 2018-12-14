using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public List<Author> Authors { get; set; }

        public Book() { }

        public Book(string title, decimal price, string genre, List<Author> authors)
        {
            this.Title = title;
            this.Price = price;
            this.Genre = genre;
            this.Authors = authors;
        }

        public Author AddAuthor()
        {
            Console.WriteLine("\n\t Name of author: ");
            string nameOfAuthor = Console.ReadLine();

            Console.WriteLine("\n\t E-mail of author: ");
            string emailOfAuthor = Console.ReadLine();

            var author = new Author(nameOfAuthor,emailOfAuthor);

            return author;
        }

        public decimal GetPrice()
        {
            if (this.Genre.Contains("SF"))
            {
                return (this.Price * Convert.ToDecimal(0.85));
            }
            if (this.Genre.Contains("Drama"))
            {
                return (this.Price * Convert.ToDecimal(0.90));
            }
            return this.Price;
        }

        public void Print()
        {
            Console.WriteLine($"\n\t Book title: {this.Title}");
            Console.WriteLine($"\t\t Genre: {this.Genre}");
            Console.WriteLine($"\t\t Price: {this.Price} lei");
            Console.WriteLine($"\t\t Price (after discount): {this.GetPrice()} lei");
            foreach (var auth in Authors)
            {
                auth.Print();
            }
        }
    }
}
