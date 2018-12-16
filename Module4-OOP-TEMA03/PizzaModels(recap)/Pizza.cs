using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModels_recap_;

namespace PizzaModels_recap_
{
    public class Pizza
    {
        public Pizza(string name, PizzaBase baseOfPizza)
        {
            this.Name = name;
            this.BaseOfPizza = baseOfPizza;
            this.ToppOfPizza = new List<PizzaTopping>();//initializata in ctor
        }

        public string Name { get; }//set este definit prin ctor
        public PizzaBase BaseOfPizza { get; }
        private List<PizzaTopping> ToppOfPizza { get; }//private pt interzice add exterior

        public void AddTopping(PizzaTopping topping)
        {
            this.ToppOfPizza.Add(topping);
        }

        public double TotalCost()
        {
            double totalCost = this.BaseOfPizza.Cost;
            foreach (var pizzaTopping in ToppOfPizza)
            {
                totalCost = totalCost + pizzaTopping.Cost;
            }
            return totalCost;
        }

        public void Print()
        {
            Console.WriteLine($"\n\tPizza {Name}");
            this.BaseOfPizza.Print();
            Console.WriteLine("\tToppings:");
            foreach (var pizzaTopping in this.ToppOfPizza)
            {
                pizzaTopping.Print();
            }
            Console.WriteLine($"\tTotal cost: (${this.TotalCost()})");
            Console.WriteLine("\n");
        }
    }
}
