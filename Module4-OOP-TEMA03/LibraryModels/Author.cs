using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Author
    {
        public string Name { get; }

        public string Email { get; }

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
                this.Email = "invalid format";
            }
        }

        public void Print()
        {
            Console.WriteLine($"\t\t\t Author name: {this.Name}, E-mail: {this.Email}");
        }
    }
}
