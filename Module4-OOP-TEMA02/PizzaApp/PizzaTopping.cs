using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class PizzaTopping
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public PizzaTopping(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public void Print()
        {
            Console.WriteLine($"\n\t\t\t Topping '{Name}' = {Cost} lei");
        }
    }
}
