using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModels_recap_;

namespace Module4_OOP_TEMA03
{
    class Program
    {
        static void Main()
        {
            var regularPizza = new PizzaBase("Regular",10);
            var thickPizza = new PizzaBase("Thick", 10);
            var italianPizza = new PizzaBase("Italian",10);

            var pizza1 = new Pizza("PIZZA 1",regularPizza);
            pizza1.AddTopping(new PizzaTopping("Meat", 10));
            pizza1.AddTopping(new PizzaTopping("Cheese",5));

            var pizza2 = new Pizza("PIZZA 2",italianPizza);
            pizza2.AddTopping(new PizzaTopping ("Cheese",5));
            pizza2.AddTopping(new PizzaTopping("Vegetable",3));

            pizza1.Print();
            pizza2.Print();

            Console.ReadLine();
        }
    }
}
