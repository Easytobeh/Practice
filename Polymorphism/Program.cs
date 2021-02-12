using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee employee in employees)
                employee.PrintFullName();
        }
    }

    public class Employee
    {
        public string firstName = "John";
        public string lastName = "Doe";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} - Parttime");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} - Fulltime");
        }
    }
     public class TemporaryEmployee : Employee

    {
        //public override void PrintFullName()
        //{
        //    Console.WriteLine($"{firstName} {lastName} - Temporary");
        //}
    }

}
 