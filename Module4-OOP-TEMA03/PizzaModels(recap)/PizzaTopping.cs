using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModels_recap_;

namespace PizzaModels_recap_
{
    public class PizzaTopping
    {
        private List<string> _toppingTypes = new List<string> { "cheese", "meat", "vegetable"};

        public PizzaTopping(string name, double cost)
        {
            if (_toppingTypes.Contains(name.ToLower()))
            {
                this.Name = name;
                this.Cost = cost;
            }
            else
            {
                Console.WriteLine($"\t '{name}' is an invalid topping!");
            }
        }

        public string Name { get; }
        public double Cost { get; }

        public void Print()
        {
            if (this.Name.ToLower() == "meat")
            {
                Console.WriteLine($"\t\t{this.Name.ToUpper()} (${this.Cost})");
                return;
            }
            Console.WriteLine($"\t\t{this.Name} (${this.Cost})");
        }
    }
}
