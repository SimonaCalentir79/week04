using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex7_Models;

namespace Ex7_AnimalHierarchy
{
    class Program
    {
        public static void Main()
        {
            var listOfAnimals = new Lists();
            //-----------------------------------------------------------//
            var dog1 = new Dog("Dog01", 5, "male");
            var dog2 = new Dog("Dog02", 3, "female");
            var dog3 = new Dog("Dog03", 8, "male");

            listOfAnimals.AddDog(dog1);
            listOfAnimals.AddDog(dog2);
            listOfAnimals.AddDog(dog3);

            listOfAnimals.PrintDogs();
            //-----------------------------------------------------------//
            var cat1 = new Cat("Cat01", 3, "female");
            var cat2 = new Cat("Cat02", 2, "male");
            var cat3 = new Cat("Cat03", 4, "female");

            listOfAnimals.AddCat(cat1);
            listOfAnimals.AddCat(cat2);
            listOfAnimals.AddCat(cat3);

            listOfAnimals.PrintCats();
            //-----------------------------------------------------------//
            var frog1 = new Frog("Frog01", 2, "female");
            var frog2 = new Frog("Frog02", 1, "male");
            var frog3 = new Frog("Frog03", 3, "male");

            listOfAnimals.AddFrog(frog1);
            listOfAnimals.AddFrog(frog2);
            listOfAnimals.AddFrog(frog3);

            listOfAnimals.PrintFrogs();
            //-----------------------------------------------------------//
            var kitten1 = new Kitten("Kitten01", Convert.ToDecimal(0.1), "female");
            var kitten2 = new Kitten("Kitten02", Convert.ToDecimal(0.5), "female");
            var kitten3 = new Kitten("Kitten03", Convert.ToDecimal(0.8), "female");
            var kitten4 = new Kitten("Kitten04", Convert.ToDecimal(0.7), "male");

            listOfAnimals.AddKitten(kitten1);
            listOfAnimals.AddKitten(kitten2);
            listOfAnimals.AddKitten(kitten3);

            listOfAnimals.PrintKittens();
            //-----------------------------------------------------------//
            var tomcat1 = new Tomcat("Tomcat01", Convert.ToDecimal(0.3), "male");
            var tomcat2 = new Tomcat("Tomcat02", Convert.ToDecimal(0.9), "male");
            var tomcat3 = new Tomcat("Tomcat03", Convert.ToDecimal(0.2), "male");
            var tomcat4 = new Tomcat("Tomcat04", Convert.ToDecimal(0.5), "female");

            listOfAnimals.AddTomcat(tomcat1);
            listOfAnimals.AddTomcat(tomcat2);
            listOfAnimals.AddTomcat(tomcat3);

            listOfAnimals.PrintTomcats();
            //-----------------------------------------------------------//

            listOfAnimals.avgAge();

            Console.ReadLine();
        }
    }
}
