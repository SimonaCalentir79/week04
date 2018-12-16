using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Models
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\t {this.FirstName} {this.LastName}");
        }
    }
}
