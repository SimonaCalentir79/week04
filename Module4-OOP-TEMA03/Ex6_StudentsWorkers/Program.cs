using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex6_Models;

namespace Ex6_StudentsWorkers
{
    class Program
    {
        static void Main()
        {
            var newList = new Lists();//initializare lista
            newList.AddStudent(new Student("Nume06", "Prenume00", 3));//populare lista studenti
            newList.AddStudent(new Student("Nume03", "Prenume01", 4));
            newList.AddStudent(new Student("Nume01", "Prenume08", 2));
            newList.AddStudent(new Student("Nume07", "Prenume02", 1));
            newList.AddStudent(new Student("Nume02", "Prenume05", 6));
            newList.AddStudent(new Student("Nume05", "Prenume09", 10));
            newList.AddStudent(new Student("Nume09", "Prenume04", 7));
            newList.AddStudent(new Student("Nume04", "Prenume03", 5));
            newList.AddStudent(new Student("Nume08", "Prenume07", 9));
            newList.AddStudent(new Student("Nume00", "Prenume06", 8));

            newList.AddWorker(new Worker("Nume16", "Prenume10", 600, 8));//populare lista lucratori
            newList.AddWorker(new Worker("Nume13", "Prenume11", 700, 8));
            newList.AddWorker(new Worker("Nume11", "Prenume18", 800, 8));
            newList.AddWorker(new Worker("Nume17", "Prenume12", 900, 8));
            newList.AddWorker(new Worker("Nume12", "Prenume15", 500, 8));
            newList.AddWorker(new Worker("Nume15", "Prenume19", 400, 8));
            newList.AddWorker(new Worker("Nume19", "Prenume14", 300, 8));
            newList.AddWorker(new Worker("Nume14", "Prenume13", 200, 8));
            newList.AddWorker(new Worker("Nume18", "Prenume17", 1000, 8));
            newList.AddWorker(new Worker("Nume10", "Prenume16", 100, 8));

            //------------------------------------------------------------------//

            Console.WriteLine("\n\t STUDENT LIST: ");//afisare lista studenti
            newList.PrintLstStud();

            newList.OrderStudByGrade();//sortare si afisare lista sortata studenti

            //------------------------------------------------------------------//

            Console.WriteLine("\n\t WORKERS LIST:");//afisare lista lucratori
            newList.PrintLstWrk();

            newList.OrderWkrByMoney();//sortare si afisare lista sortata lucratori

            //------------------------------------------------------------------//

            Console.WriteLine("\n\t ALL HUMANS: ");
            newList.PrintAll(newList.MergeLists());//afisare lista oameni

            newList.OrderByFName(newList.MergeLists());//sortare si afisare lista sortata oameni

            newList.OrderByLName(newList.MergeLists());//sortare si afisare lista sortata oameni

            Console.ReadLine();
        }
    }
}
