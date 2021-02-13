using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInUsage
{
    delegate bool IsPromotableDelegate(Employee employee);

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { Id = 101, Name = "John", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { Id = 101, Name = "David", Salary = 3000, Experience = 6 });
            empList.Add(new Employee() { Id = 101, Name = "Mike", Salary = 6000, Experience = 3 });

            //Create instance of delegate           
            IsPromotableDelegate promotable = new IsPromotableDelegate(IsPromotable);

            Employee thisEmployee = new Employee();
            thisEmployee.PromoteEmployee(empList, employee => employee.Experience >= 5);
        }

        //Define Logic for promoting employees
        public static bool IsPromotable(Employee employee)
        {
            if (employee.Experience >= 5)
                return true;
            else
                return false;
        }

    }
    
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
        public sbyte Experience { get; set; }
        public void PromoteEmployee(List<Employee> employeeList, IsPromotableDelegate Promote)
        {
            foreach (Employee employee in employeeList)
            {
                if (Promote(employee))
                {
                    Console.WriteLine($"{employee.Name} is promoted");
                }
            }
        }
    }
}
