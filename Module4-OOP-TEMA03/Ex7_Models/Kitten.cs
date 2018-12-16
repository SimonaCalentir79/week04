using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Models
{
    public class Kitten:Cat
    {
        public Kitten(string name, decimal age, string gender):base(name,age,gender)
        {
            if (gender.ToLower() == "female")
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }
            else
            {
                Console.WriteLine($"\n\n\t {this.Name} isn't a Kitten! It's a Tomcat!");
            }
        }
    }
}
