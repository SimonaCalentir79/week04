using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Models
{
    public class Tomcat:Cat
    {
        public Tomcat(string name, decimal age, string gender):base(name,age,gender)
        {
            if (gender.ToLower() == "male")
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }
            else
            {
                Console.WriteLine($"\n\n\t {this.Name} isn't a Tomcat! It's a Kitten!");
            }
        }
    }
}
