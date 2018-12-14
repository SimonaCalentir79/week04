using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class Pizza
    {
        public string Name { get; set; }
        public PizzaBase PizzaBase { get; set; }
        public List<PizzaTopping> PizzaToppings { get; set; }

        public Pizza() { }

        public Pizza(string name, PizzaBase baseOfPizza, List <PizzaTopping > listOfTopp)
        {
            this.Name = name;
            this.PizzaBase = baseOfPizza;
            this.PizzaToppings = listOfTopp;
        }

        public Pizza CreatePizza()
        {
            Console.WriteLine("\n\t Name of pizza: ");
            string name = Console.ReadLine();

            Console.WriteLine("\n\t Base of pizza: ");
            string baseOfPizza = Console.ReadLine();

            Console.WriteLine("\n\t Cost of base for pizza:");
            double costOfBase = Convert.ToDouble(Console.ReadLine ());

            this.Name = name;
            this.PizzaBase = new PizzaBase(baseOfPizza,costOfBase);

            Console.WriteLine("\n\t Number of toppings to add: ");
            int nrOfTopp = Convert.ToInt32(Console.ReadLine());

            this.PizzaToppings = new List<PizzaTopping>();
            for (int i = 0; i < nrOfTopp; i++)
            {
                this.PizzaToppings.Add(this.AddTopping());
            }

            var newPizza = new Pizza(this.Name ,this.PizzaBase ,this.PizzaToppings);
            return newPizza;
        }

        public PizzaTopping AddTopping()
        {
            Console.WriteLine("\n\t Name of topping: ");
            string nameOftopp = Console.ReadLine();

            Console.WriteLine("\n\t Cost of topping: ");
            double costOfTopp = Convert.ToDouble(Console.ReadLine());

            var newTopp = new PizzaTopping(nameOftopp,costOfTopp);

            return newTopp;
        }

        public double GetPriceOfBase()
        {
            if (this.PizzaBase.Name == "Italian")
            {
                return this.PizzaBase.Cost * 1.5;
            }
            return this.PizzaBase.Cost;
        }
        public double TotalCost()
        {
            double toppPrice = 0;
            foreach (var top in PizzaToppings)
            {
                toppPrice = toppPrice + top.Cost;
            }
            return this.GetPriceOfBase() + toppPrice;
        }

        public void Print()
        {
            Console.WriteLine($"\n\t Pizza '{Name}'");
            Console.WriteLine($"\n\t\t Base '{PizzaBase.Name}' = {PizzaBase.Cost} lei");
            if (PizzaBase.Name == "Italian")
            {
                Console.WriteLine($"\n\t\t Base '{PizzaBase.Name}' (after calculation) = {this.GetPriceOfBase()} lei.");
            }
            foreach (var top in this.PizzaToppings.ToList())
            {
                top.Print();
            }
            Console.WriteLine($"\n\t Total cost: {this.TotalCost()} lei");
        }
    }
}
