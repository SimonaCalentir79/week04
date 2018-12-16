using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Models
{
    public class Lists
    {
        private List<Student> lstStudents = new List<Student>();
        private List<Worker> lstWorkers = new List<Worker>();

        public void AddStudent(Student student)
        {
            lstStudents.Add(student);
        }

        public void PrintLstStud()
        {
            foreach (var stud in lstStudents)
            {
                stud.Print();
            }
        }

        public void OrderStudByGrade()
        {
            List<Student> orderedLstStd = lstStudents.OrderBy(x => x.Grade).ToList();
            Console.WriteLine("\n\t STUDENT LIST (ordered by 'Grade'): ");
            foreach (var stud in orderedLstStd)
            {
                stud.Print();
            }
        }

        //------------------------------------------------------------------//

        public void AddWorker(Worker worker)
        {
            lstWorkers.Add(worker);
        }

        public void OrderWkrByMoney()
        {
            List<Worker> orderedLstWrk = lstWorkers.OrderBy(x => x.MoneyPerHour()).ToList();
            Console.WriteLine("\n\t WORKER LIST (ordered by 'Money/Hour'): ");
            foreach (var worker in orderedLstWrk)
            {
                worker.Print();
            }
        }

        public void PrintLstWrk()
        {
            foreach (var worker in lstWorkers)
            {
                worker.Print();
            }
        }

        //------------------------------------------------------------------//

        public List<Human> MergeLists()
        {
            var listAll = new List<Human>(lstStudents.Count + lstWorkers.Count);
            listAll.AddRange(lstStudents);
            listAll.AddRange(lstWorkers);
            return listAll;
        }

        public void OrderByFName(List<Human> lstHum)
        {
            List<Human> lstHumanByFName = lstHum.OrderBy(x => x.FirstName).ToList();
            Console.WriteLine("\n\t List of humans (ordered by 'FirstName')");
            foreach (var human in lstHumanByFName)
            {
                human.Print();
            }
        }

        public void OrderByLName(List<Human> lstHum)
        {
            List<Human> lstHumanByLName = lstHum.OrderBy(x => x.LastName).ToList();
            Console.WriteLine("\n\t List of humans (ordered by 'LastName')");
            foreach (var human in lstHumanByLName)
            {
                human.Print();
            }
        }

        public void PrintAll(List<Human> lstHuman)
        {
            foreach (var human in lstHuman)
            {
                human.Print();
            }
        }
    }
}
