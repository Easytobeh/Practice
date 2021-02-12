using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee()
            {
                Id = 101,
                Name = "Mary",
                Salary = 5000,
                Experience = 5
            });

            empList.Add(new Employee()
            {
                Id = 101,
                Name = "John",
                Salary = 4000,
                Experience = 4
            });

            empList.Add(new Employee()
            {
                Id = 101,
                Name = "David",
                Salary = 3000,
                Experience = 6
            });
            empList.Add(new Employee()
            {
                Id = 101,
                Name = "Mike",
                Salary = 6000,
                Experience = 3
            });
            Employee thisEmployee = new Employee();
            thisEmployee.PromoteEmployee(empList);


            
        }
         
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
        public sbyte Experience{ get; set; }
        public void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                { 
                    Console.WriteLine($"{employee.Name} is promoted");
                }
            }
        }
    }
}
