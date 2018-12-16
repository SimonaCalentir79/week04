using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public decimal Age { get; set; }
        public string Gender { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t name: {this.Name}, age: {this.Age}, gender: {this.Gender}");
        }
    }
}
