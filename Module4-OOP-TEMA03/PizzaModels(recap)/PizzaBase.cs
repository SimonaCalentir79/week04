using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModels_recap_;

namespace PizzaModels_recap_
{
    public class PizzaBase
    {
        private List<string> _lstPizzaBase = new List<string> { "thick", "regular", "italian"};
        public PizzaBase(string name, double cost)
        {
            if (_lstPizzaBase.Contains(name.ToLower()))
            {
                this.Name = name;
                this.Cost = cost;
            }
            else
            {
                Console.WriteLine($"{name} is an invalid pizza base.");
            }
        }
        public string Name { get; }
        public double Cost { get; }

        public void Print()
        {
            Console.WriteLine($"\tBase {this.Name} (${this.Cost})");
        }
    }
}
