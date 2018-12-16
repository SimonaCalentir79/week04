using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Models
{
    public class Lists
    {
        private List<Dog> lstDog = new List<Dog>();
        private List<Cat> lstCat = new List<Cat>();
        private List<Frog> lstFrog = new List<Frog>();
        private List<Kitten> lstKitten = new List<Kitten>();
        private List<Tomcat> lstTomcat = new List<Tomcat>();

        public void AddDog(Dog dog)
        {
            lstDog.Add(dog);
        }
        public void AddCat(Cat cat)
        {
            lstCat.Add(cat);
        }
        public void AddFrog(Frog frog)
        {
            lstFrog.Add(frog);
        }
        public void AddKitten(Kitten kitten)
        {
            lstKitten.Add(kitten);
        }
        public void AddTomcat(Tomcat tomcat)
        {
            lstTomcat.Add(tomcat);
        }

        public void PrintDogs()
        {
            Console.WriteLine("\n DOG LIST: ");
            foreach (var dog in lstDog)
            {
                dog.Print();
                dog.Sound();
            }
        }
        public void PrintCats()
        {
            Console.WriteLine("\n CAT LIST: ");
            foreach (var cat in lstCat)
            {
                cat.Print();
                cat.Sound();
            }
        }

        public void PrintFrogs()
        {
            Console.WriteLine("\n FROG LIST: ");
            foreach (var frog in lstFrog)
            {
                frog.Print();
                frog.Sound();
            }
        }

        public void PrintKittens()
        {
            Console.WriteLine("\n KITTEN LIST: ");
            foreach (var kitten in lstKitten)
            {
                kitten.Print();
                kitten.Sound();
            }
        }

        public void PrintTomcats()
        {
            Console.WriteLine("\n TOMCAT LIST: ");
            foreach (var tomcat in lstTomcat)
            {
                tomcat.Print();
                tomcat.Sound();
            }
        }

        public void avgAge()
        {
            var listSome = new List<Animal>(lstCat.Count + lstDog.Count + lstFrog.Count);
            listSome.AddRange(lstCat);
            listSome.AddRange(lstDog);
            listSome.AddRange(lstFrog);

            var listAll = new List<Animal>(listSome.Count + lstKitten.Count + lstTomcat.Count);
            listAll.AddRange(listSome);
            listAll.AddRange(lstKitten);
            listAll.AddRange(lstTomcat);

            decimal sum = 0;
            decimal average = 0;

            foreach (var animal in listSome)
                sum = sum + animal.Age;
            average = sum / listSome.Count;
            average = Decimal.Round(average, 2);

            Console.WriteLine($"\n\t Average age of ALL animals is {average}.");

            foreach (var animal in listAll)
                sum = sum + animal.Age;
            average = sum / listAll.Count;
            average = Decimal.Round(average, 2);

            Console.WriteLine($"\n\t Average age of all CATS, DOGS & FROGS is {average}.");
        }

    }
}
