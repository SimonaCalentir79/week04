﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Models
{
    public class Dog:Animal, ISound
    {
        public Dog(string name, decimal age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void Sound()
        {
            Console.WriteLine($"\t\t\t Sound: 'wouf!wouf!'");
        }
    }
}
