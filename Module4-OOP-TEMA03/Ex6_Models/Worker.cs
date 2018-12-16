using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Models
{
    public class Worker:Human
    {
        public decimal WeekSalary { get; }
        public int WorkHoursPerDay { get; }

        public Worker(string lastName, string firstName, decimal weekSalary, int workHoursPerDay)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / 5 / Convert.ToDecimal(this.WorkHoursPerDay));
        }

        public new void Print()
        {
            Console.WriteLine($"\t\t worker: {this.LastName} {this.FirstName}, {this.WeekSalary} EUR/week, {this.WorkHoursPerDay} h/day -- {this.MoneyPerHour()} EUR/h");
        }
    }
}
