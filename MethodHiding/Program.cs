using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FE = new FullTimeEmployee();
            FE.firstName = "Fulltime";
            FE.lastName = "Employee";
            FE.PrintFullName();

            PartTimeEmployee PE = new PartTimeEmployee();
            PE.firstName = "Parttime";
            PE.lastName = "Employee";
            PE.PrintFullName();

        }
    }

    public class Employee
    {
        public string firstName, lastName;

        public Employee()
        {

        }
        //public Employee(string _firstName, string _lastName)
        //{
        //    this.firstName = _firstName;
        //    this.lastName = _lastName;
        //}
        public void PrintFullName()
        {
            Console.WriteLine("Fullname: " + firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
    }

    public class PartTimeEmployee : Employee
    {
        public void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine("Fullname: " + firstName + " " + lastName + "-Part");
        }
    }
}
