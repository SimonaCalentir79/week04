using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Interface_recap_
{
    public class Student: Human, IHumanBehavior
    {
        public int Grade { get; set; }

        public Student()
        {

        }
        public void Walk(string direction)
        {

        }
    }
}
