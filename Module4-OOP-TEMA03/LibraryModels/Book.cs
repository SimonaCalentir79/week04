using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Book
    {
        public string Title { get; }
        public decimal Price { get; }
        public string Genre { get; }
        private List<Author> Authors { get; }

        public Book(string title, decimal price, string genre)
        {
            this.Title = title;
            this.Price = price;
            this.Genre = genre;
            this.Authors = new List<Author>();
        }

        public void AddAuthor(Author author)
        {
            if (!this.Authors.Contains(author))//aici nu functioneaza instructiunea - de ce?
            {
                this.Authors.Add(author);
            }
        }

        public decimal GetPrice()
        {
            if (this.Genre.ToLower() == "sf")
            {
                return this.Price * Convert.ToDecimal(0.85);
            }
            if (this.Genre.ToLower() == "drama")
            {
                return this.Price * Convert.ToDecimal(0.90);
            }
            return this.Price;
        }

        public void Print()
        {
            Console.WriteLine($"\n\t\t Title: {this.Title}, Genre: {this.Genre}");
            Console.WriteLine($"\t\t Price: {this.Price} lei");
            Console.WriteLine($"\t\t Price (after discount): {this.GetPrice()} lei");
            foreach (var auth in this.Authors)
            {
                auth.Print();
            }
        }
    }
}
