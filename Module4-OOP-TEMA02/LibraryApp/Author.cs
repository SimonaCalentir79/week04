using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Author
    {
        public Author(string name, string email)
        {
            if (email.Contains("@"))
            {
                this.Name = name;
                this.Email = email;
            }
            else
            {
                this.Name = name;
                this.Email = "'invalid format'";
            }
        }
        public string Name { get; set; }

        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\t\t Author name: '{this.Name}', e-mail: {this.Email}");
        }
    }
}
