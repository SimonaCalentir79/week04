using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class PizzaBase
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public PizzaBase(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public void Print()
        {
            Console.WriteLine($"\n\t Base '{Name}' = {Cost} lei.");
        }
    }


}
