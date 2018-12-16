using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Models
{
    public class Student:Human
    {
        public int Grade { get; }

        public Student(string lastName, string firstName, int grade)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Grade = grade;
        }

        public new void Print()
        {
            Console.WriteLine($"\t\t student: {this.LastName} {this.FirstName}, grade: {this.Grade}");
        }
    }
}
